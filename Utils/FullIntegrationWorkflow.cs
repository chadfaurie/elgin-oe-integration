using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Services;
using ElginOeIntegration.Models;

namespace ElginOeIntegration.Utils
{
    public static class FullIntegrationWorkflow
    {
        public static async Task RunCompleteWorkflowAsync()
        {
            Console.WriteLine("=== Starting Woolworths to Sage300 OE Integration Workflow ===");
            Console.WriteLine();

            try
            {
                // Step 1: Initialize services
                Console.WriteLine("Step 1: Initializing services...");
                var services = InitializeServices();
                
                // Step 2: Scrape data from Woolworths
                Console.WriteLine("Step 2: Scraping data from Woolworths...");
                await services.scraperService.ScrapeAsync();
                
                // Step 3: Process downloaded XML files
                Console.WriteLine("Step 3: Processing downloaded XML files...");
                var planDownload = await ProcessDownloadedXmlFiles(services.xmlExtractor, services.woolworthsConfig.StoragePath);
                
                if (planDownload == null)
                {
                    Console.WriteLine("No XML data found to process. Workflow terminated.");
                    return;
                }

                // Step 4: Map XML data to Sage300 OE orders
                Console.WriteLine("Step 4: Mapping XML data to Sage300 OE orders...");
                var oeImportData = await services.dataMapper.MapPlanDownloadToOeOrdersAsync(planDownload);
                
                // Step 5: Import orders into Sage300
                Console.WriteLine("Step 5: Importing orders into Sage300 OE...");
                var importResult = await services.sage300Service.ImportOrdersAsync(oeImportData);
                
                // Step 6: Display results
                Console.WriteLine("Step 6: Integration Results");
                DisplayResults(importResult);
                
                Console.WriteLine();
                Console.WriteLine("=== Integration Workflow Completed Successfully ===");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Integration workflow failed: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        private static (
            WoolworthsScraperService scraperService,
            XmlExtractorService xmlExtractor,
            DataMappingService dataMapper,
            Sage300OeService sage300Service,
            WoolworthsConfig woolworthsConfig
        ) InitializeServices()
        {
            // Woolworths configuration
            var woolworthsConfig = new WoolworthsConfig
            {
                SiteUrl = Environment.GetEnvironmentVariable("WOOLWORTHS_SITE_URL") ?? "https://example.com",
                Username = Environment.GetEnvironmentVariable("WOOLWORTHS_USERNAME") ?? "your-username",
                Password = Environment.GetEnvironmentVariable("WOOLWORTHS_PASSWORD") ?? "your-password",
                StoragePath = Environment.GetEnvironmentVariable("WOOLWORTHS_STORAGE_PATH") ?? "./downloads"
            };

            // Sage300 configuration
            var sage300Config = new Sage300Config
            {
                ServerName = Environment.GetEnvironmentVariable("SAGE300_SERVER") ?? "localhost",
                DatabaseId = Environment.GetEnvironmentVariable("SAGE300_DATABASE") ?? "SAMLTD",
                UserId = Environment.GetEnvironmentVariable("SAGE300_USER") ?? "ADMIN",
                Password = Environment.GetEnvironmentVariable("SAGE300_PASSWORD") ?? "password",
                Version = "68A"
            };

            // Initialize services
            var scraperService = new WoolworthsScraperService(woolworthsConfig);
            var xmlExtractor = new XmlExtractorService();
            var dataMapper = new DataMappingService();
            var sage300Service = new Sage300OeService(sage300Config);

            Console.WriteLine("✓ Services initialized successfully");
            return (scraperService, xmlExtractor, dataMapper, sage300Service, woolworthsConfig);
        }

        private static async Task<PlanDownload> ProcessDownloadedXmlFiles(XmlExtractorService xmlExtractor, string downloadPath)
        {
            try
            {
                if (!Directory.Exists(downloadPath))
                {
                    Console.WriteLine($"Download directory does not exist: {downloadPath}");
                    return null;
                }

                var xmlFiles = Directory.GetFiles(downloadPath, "*.xml");
                
                if (xmlFiles.Length == 0)
                {
                    Console.WriteLine("No XML files found in download directory");
                    return null;
                }

                Console.WriteLine($"Found {xmlFiles.Length} XML file(s) to process");

                // Process the first/latest XML file
                var xmlFile = xmlFiles[0];
                Console.WriteLine($"Processing file: {Path.GetFileName(xmlFile)}");
                
                var xmlContent = await File.ReadAllTextAsync(xmlFile);
                var planDownload = await xmlExtractor.ExtractXmlDataAsync(xmlContent);

                Console.WriteLine($"✓ Successfully extracted {planDownload.PlanDetail.Count} plan details");
                return planDownload;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing XML files: {ex.Message}");
                throw;
            }
        }

        private static void DisplayResults(Sage300ImportResult result)
        {
            Console.WriteLine();
            Console.WriteLine("=== IMPORT RESULTS ===");
            Console.WriteLine($"Success: {(result.Success ? "✓ YES" : "✗ NO")}");
            Console.WriteLine($"Message: {result.Message}");
            Console.WriteLine($"Records Processed: {result.RecordsProcessed}");
            Console.WriteLine($"Records Successful: {result.RecordsSuccessful}");
            Console.WriteLine($"Records Failed: {result.RecordsFailed}");
            Console.WriteLine($"Processed At: {result.ProcessedAt:yyyy-MM-dd HH:mm:ss}");

            if (result.Errors.Any())
            {
                Console.WriteLine();
                Console.WriteLine("ERRORS:");
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"  • {error}");
                }
            }

            if (result.FailedRecords.Any())
            {
                Console.WriteLine();
                Console.WriteLine("FAILED RECORDS:");
                foreach (var failedRecord in result.FailedRecords)
                {
                    Console.WriteLine($"  • {failedRecord}");
                }
            }
        }

        public static async Task RunTestWorkflowAsync()
        {
            Console.WriteLine("=== Running Test Workflow (Sage300 Connection Test) ===");
            
            try
            {
                var sage300Config = new Sage300Config
                {
                    ServerName = "localhost",
                    DatabaseId = "SAMLTD",
                    UserId = "ADMIN",
                    Password = "password"
                };

                var sage300Service = new Sage300OeService(sage300Config);

                Console.WriteLine("Testing Sage300 connection...");
                var connectionTest = await sage300Service.TestConnectionAsync();
                
                if (connectionTest)
                {
                    Console.WriteLine("✓ Sage300 connection test successful");
                    
                    // Test order number generation
                    await sage300Service.ConnectAsync();
                    var nextOrderNumber = await sage300Service.GetNextOrderNumberAsync();
                    Console.WriteLine($"✓ Generated order number: {nextOrderNumber}");
                    
                    await sage300Service.DisconnectAsync();
                }
                else
                {
                    Console.WriteLine("✗ Sage300 connection test failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test workflow failed: {ex.Message}");
            }
        }
    }
}
