using System;
using System.Threading.Tasks;
using ElginOeIntegration.Models;
using ElginOeIntegration.Services;

namespace ElginOeIntegration.Utils
{
    public static class ScraperFactory
    {
        public static WoolworthsScraperService CreateWoolworthsScraper()
        {
            // In a real application, these would come from configuration files, environment variables, or dependency injection
            var config = new WoolworthsConfig
            {
                SiteUrl = Environment.GetEnvironmentVariable("WOOLWORTHS_SITE_URL") ?? "https://example.com",
                Username = Environment.GetEnvironmentVariable("WOOLWORTHS_USERNAME") ?? "your-username",
                Password = Environment.GetEnvironmentVariable("WOOLWORTHS_PASSWORD") ?? "your-password",
                StoragePath = Environment.GetEnvironmentVariable("WOOLWORTHS_STORAGE_PATH") ?? "./downloads"
            };

            return new WoolworthsScraperService(config);
        }

        public static async Task RunWoolworthsScrapingAsync()
        {
            var scraper = CreateWoolworthsScraper();
            
            try
            {
                await scraper.ScrapeAsync();
            }
            finally
            {
                await scraper.DisposeAsync();
            }
        }
    }
}
