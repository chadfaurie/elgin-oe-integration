using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Services;
using ElginOeIntegration.Models;
using ElginOeIntegration.Exceptions;

namespace ElginOeIntegration.Utils
{
    public static class IntegrationExample
    {
        public static async Task RunFullIntegrationAsync()
        {
            var config = new WoolworthsConfig
            {
                SiteUrl = Environment.GetEnvironmentVariable("WOOLWORTHS_SITE_URL") ?? "https://example.com",
                Username = Environment.GetEnvironmentVariable("WOOLWORTHS_USERNAME") ?? "your-username",
                Password = Environment.GetEnvironmentVariable("WOOLWORTHS_PASSWORD") ?? "your-password",
                StoragePath = Environment.GetEnvironmentVariable("WOOLWORTHS_STORAGE_PATH") ?? "./downloads"
            };

            var scraperService = new WoolworthsScraperService(config);
            var xmlExtractorService = new XmlExtractorService();

            try
            {
                Console.WriteLine("Starting Woolworths data integration...");

                // Step 1: Scrape the data
                Console.WriteLine("Step 1: Scraping data from Woolworths...");
                await scraperService.ScrapeAsync();

                // Step 2: Find and process the downloaded XML file
                Console.WriteLine("Step 2: Processing downloaded XML files...");
                await ProcessDownloadedFiles(xmlExtractorService, config.StoragePath);

                Console.WriteLine("Integration completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Integration failed: {ex.Message}");
                throw;
            }
            finally
            {
                await scraperService.DisposeAsync();
            }
        }

        private static async Task ProcessDownloadedFiles(IXmlExtractorService xmlExtractor, string downloadPath)
        {
            try
            {
                if (!Directory.Exists(downloadPath))
                {
                    throw new FileReadError($"Download directory does not exist: {downloadPath}");
                }

                var xmlFiles = Directory.GetFiles(downloadPath, "*.xml");
                
                if (xmlFiles.Length == 0)
                {
                    Console.WriteLine("No XML files found in download directory");
                    return;
                }

                foreach (var xmlFile in xmlFiles)
                {
                    Console.WriteLine($"Processing file: {Path.GetFileName(xmlFile)}");
                    
                    try
                    {
                        var xmlContent = await File.ReadAllTextAsync(xmlFile);
                        var planDownload = await xmlExtractor.ExtractXmlDataAsync(xmlContent);

                        Console.WriteLine($"Successfully processed {planDownload.PlanDetail.Count} plan details from {Path.GetFileName(xmlFile)}");

                        // Here you could save to database, generate reports, etc.
                        await ProcessPlanData(planDownload);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to process {Path.GetFileName(xmlFile)}: {ex.Message}");
                        // Continue processing other files
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FileReadError($"Error processing downloaded files: {ex.Message}", ex);
            }
        }

        private static async Task ProcessPlanData(PlanDownload planDownload)
        {
            // Example processing of the extracted data
            await Task.Run(() =>
            {
                var groupedByRegion = planDownload.PlanDetail
                    .GroupBy(p => p.Region)
                    .ToDictionary(g => g.Key, g => g.Count());

                Console.WriteLine("Plan details by region:");
                foreach (var region in groupedByRegion)
                {
                    Console.WriteLine($"  {region.Key}: {region.Value} items");
                }

                var totalQuantity = planDownload.PlanDetail.Sum(p => p.Quantity);
                Console.WriteLine($"Total quantity across all plans: {totalQuantity}");
            });
        }
    }
}
