using ElginOeIntegration.Models;
using ElginOeIntegration.Modules;
using PuppeteerSharp;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ElginOeIntegration.Services
{
    public interface IWoolworthsScraperService
    {
        Task ScrapeAsync();

        string getDownloadPath();
    }

    public class WoolworthsScraperService : ScraperService, IWoolworthsScraperService
    {
        private readonly WoolworthsConfig _config;

        public WoolworthsScraperService(WoolworthsConfig config)
            : base(new ScraperOptions { DownloadPath = config.StoragePath })
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _config.ValidateConfiguration();
        }

        public string SiteName
        {
            get
            {
                if (string.IsNullOrEmpty(_config.SiteUrl))
                {
                    throw new InvalidOperationException("Site URL is not configured");
                }
                return _config.SiteUrl;
            }
        }

        public string Username
        {
            get
            {
                if (string.IsNullOrEmpty(_config.Username))
                {
                    throw new InvalidOperationException("Username is not configured");
                }
                return _config.Username;
            }
        }

        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(_config.Password))
                {
                    throw new InvalidOperationException("Password is not configured");
                }
                return _config.Password;
            }
        }

        public async Task ScrapeAsync()
        {
            try
            {
                await StartBrowserAsync();

                var page = await InitPageAsync(SiteName);

                // Try to find the providers element with different selectors and wait for it
                LogDebug("Looking for providers dropdown...");

                await SetInputElementAsync(
                    "[name=\"ctl00$cDC$cboProviders\"]",
                    "WOOLWORTHS"
                );

                // Fill in username and password
                await SetInputElementAsync(
                    "[name=\"ctl00$cDC$LoginControl$UserName\"]",
                    Username
                );

                await SetInputElementAsync(
                    "[name=\"ctl00$cDC$LoginControl$Password\"]",
                    Password
                );

                // Wait and click on first result.
                await ClickButtonAsync("[name=\"ctl00$cDC$LoginControl$LoginButton\"]");

                //await Page.WaitForNetworkIdleAsync();
                await Page.WaitForNavigationAsync();

                //await Page.WaitForSelectorAsync("[name=\"ctl00$loginView$cboSuppliers\"]");

                await SetInputElementAsync(
                    "[name=\"ctl00$loginView$cboSuppliers\"]",
                    "54506"
                );

                await Page.WaitForNavigationAsync();

                // With this:
                var reportUrl = new Uri(new Uri(SiteName), "/WebClients/SPort/SupplierPlansJDAReport.aspx").ToString();
                await Page.GoToAsync(reportUrl);

                // Region Input
                await Page.WaitForSelectorAsync("[name=\"ctl00$cDC$m_ddlRegion\"]");

                // Distribution Type
                await Page.WaitForSelectorAsync(
                    "[name=\"ctl00$cDC$m_ddlSupplyChainIndicator\"]"
                );

                // National View
                await Page.WaitForSelectorAsync("[name=\"ctl00$cDC$m_chkNationalView\"]");

                // Department
                await Page.WaitForSelectorAsync("[name=\"ctl00$cDC$m_ddlDepartment\"]");

                // Plan Date
                await Page.WaitForSelectorAsync("[name=\"ctl00$cDC$m_ddlPlanDate\"]");

                // Download Format
                await SetInputElementAsync(
                    "[name=\"ctl00$cDC$m_ddlDownloadFormat\"]",
                    "XML"
                );

                // Click download button
                await ClickButtonAsync("[name=\"ctl00$cDC$m_btnDownload\"]");

                //await Page.WaitForNetworkIdleAsync();

                await Page.WaitForNavigationAsync();

                await ClickButtonAsync("[name=\"ctl00$cDC$m_btnDownload\"]");

                await Page.WaitForNavigationAsync();

                var datePart = DateTime.Now.ToString("yyyy_MM_dd");
                var expectedFile = Path.Combine(getDownloadPath(), $"{datePart}_F21.xml");

                var timeout = 120_000; // 30 seconds
                var sw = System.Diagnostics.Stopwatch.StartNew();

                while (!File.Exists(expectedFile) && sw.ElapsedMilliseconds < timeout)
                {
                    await Task.Delay(500);
                }

                if (!File.Exists(expectedFile))
                {
                    throw new TimeoutException("Download did not complete in time.");
                }

                LogDebug("Scraping completed successfully");
            }
            catch (Exception error)
            {
                LogDebug($"Error during scraping: {error.Message}");
                throw;
            }
            finally
            {
                await CloseBrowserAsync();
            }
        }

        public override async Task DisposeAsync()
        {
            await base.DisposeAsync();
        }
    }
}
