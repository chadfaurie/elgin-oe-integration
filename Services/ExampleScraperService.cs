using System;
using System.Threading.Tasks;
using ElginOeIntegration.Modules;

namespace ElginOeIntegration.Services
{
    public class ExampleScraperService : ScraperService
    {
        public ExampleScraperService(ScraperOptions options = null) : base(options)
        {
        }

        public async Task RunExampleAsync()
        {
            try
            {
                // Start the browser
                await StartBrowserAsync();

                // Navigate to a webpage
                await InitPageAsync("https://example.com");

                // Example usage of the scraper methods
                // await SetInputElementAsync("#search-input", "test query");
                // await ClickButtonAsync("#search-button");
                // await WaitAsync(2000);
                // var result = await GetTextContentAsync("#result");

                LogDebug("Example scraping completed successfully");
            }
            catch (Exception ex)
            {
                LogDebug($"Error during scraping: {ex.Message}");
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
