using System;
using System.Threading.Tasks;
using ElginOeIntegration.Modules;
using ElginOeIntegration.Models;
using PuppeteerSharp;

namespace ElginOeIntegration.Services
{
    public interface IWoolworthsScraperService
    {
        Task ScrapeAsync();
    }

    public class WoolworthsScraperService : ScraperService
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

                await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

                await SetInputElementAsync(
                    "[name=\"ctl00$loginView$cboSuppliers\"]",
                    "54506"
                );

                await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

                await Page.GoToAsync(
                    "http://caissanet.woolworths.co.za/WebClients/SPort/SupplierPlansJDAReport.aspx"
                );

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

                await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

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
