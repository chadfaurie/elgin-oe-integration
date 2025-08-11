using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Services;
using ElginOeIntegration.Models;

namespace ElginOeIntegration.Utils
{
    interface IFullIntegrationWorkflow
    {
        Task RunCompleteWorkflowAsync();
        Task RunTestWorkflowAsync();
    }

    public class FullIntegrationWorkflow : IntegrationService, IFullIntegrationWorkflow
    {
        private readonly IWoolworthsScraperService scraperService;
        private readonly IXmlExtractorService xmlExtractorService;

        public FullIntegrationWorkflow(IWoolworthsScraperService scraperService, IXmlExtractorService xmlExtractorService )
        {
            this.scraperService = scraperService;
            this.xmlExtractorService = xmlExtractorService;
            // Constructor can be used for dependency injection if needed
        }

        public async Task RunCompleteWorkflowAsync()
        {
            LogDebug("=== Starting Woolworths to Sage300 OE Integration Workflow ===");

            try
            {
                // Step 1: Scrape data from Woolworths
                //LogDebug("Step 1: Scraping data from Woolworths...");
                //await scraperService.ScrapeAsync();

                // Step 3: Process downloaded XML files
                LogDebug("Step 3: Processing downloaded XML files...");
                var planDownload = await ProcessDownloadedXmlFiles(scraperService.getDownloadPath());

                if (planDownload == null)
                {
                    LogDebug("No XML data found to process. Workflow terminated.");
                    return;
                }

                //// Step 4: Map XML data to Sage300 OE orders
                //LogDebug("Step 4: Mapping XML data to Sage300 OE orders...");
                //var oeImportData = await services.dataMapper.MapPlanDownloadToOeOrdersAsync(planDownload);

                //// Step 5: Import orders into Sage300
                //LogDebug("Step 5: Importing orders into Sage300 OE...");
                //var importResult = await services.sage300Service.ImportOrdersAsync(oeImportData);

                //// Step 6: Display results
                //LogDebug("Step 6: Integration Results");
                //DisplayResults(importResult);

                LogDebug("=== Integration Workflow Completed Successfully ===");
            }
            catch (Exception ex)
            {
                LogDebug($"Integration workflow failed: {ex.Message}");
                LogDebug($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        private async Task<PlanDownload> ProcessDownloadedXmlFiles(string downloadPath)
        {
            try
            {
                if (!Directory.Exists(downloadPath))
                {
                    LogDebug($"Download directory does not exist: {downloadPath}");
                    return null;
                }

                var xmlFiles = Directory.GetFiles(downloadPath, "*.xml");

                if (xmlFiles.Length == 0)
                {
                    LogDebug("No XML files found in download directory");
                    return null;
                }

                LogDebug($"Found {xmlFiles.Length} XML file(s) to process");

                // Process the first/latest XML file
                var xmlFile = xmlFiles[0];
                LogDebug($"Processing file: {Path.GetFileName(xmlFile)}");

                var xmlContent = File.ReadAllText(xmlFile);
                var planDownload = await this.xmlExtractorService.ExtractXmlDataAsync(xmlContent);

                LogDebug($"✓ Successfully extracted {planDownload.PlanDetail.Count} plan details");
                return planDownload;
            }
            catch (Exception ex)
            {
                LogDebug($"Error processing XML files: {ex.Message}");
                throw;
            }
        }

        private void DisplayResults(Sage300ImportResult result)
        {
            LogDebug("=== IMPORT RESULTS ===");
            LogDebug($"Success: {(result.Success ? "✓ YES" : "✗ NO")}");
            LogDebug($"Message: {result.Message}");
            LogDebug($"Records Processed: {result.RecordsProcessed}");
            LogDebug($"Records Successful: {result.RecordsSuccessful}");
            LogDebug($"Records Failed: {result.RecordsFailed}");
            LogDebug($"Processed At: {result.ProcessedAt:yyyy-MM-dd HH:mm:ss}");

            if (result.Errors.Any())
            {

                LogDebug("ERRORS:");
                foreach (var error in result.Errors)
                {
                    LogDebug($"  • {error}");
                }
            }

            if (result.FailedRecords.Any())
            {

                LogDebug("FAILED RECORDS:");
                foreach (var failedRecord in result.FailedRecords)
                {
                    LogDebug($"  • {failedRecord}");
                }
            }
        }

        public async Task RunTestWorkflowAsync()
        {
            LogDebug("=== Running Test Workflow (Sage300 Connection Test) ===");

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

                LogDebug("Testing Sage300 connection...");
                var connectionTest = await sage300Service.TestConnectionAsync();

                if (connectionTest)
                {
                    LogDebug("✓ Sage300 connection test successful");

                    // Test order number generation
                    await sage300Service.ConnectAsync();
                    var nextOrderNumber = await sage300Service.GetNextOrderNumberAsync();
                    LogDebug($"✓ Generated order number: {nextOrderNumber}");

                    await sage300Service.DisconnectAsync();
                }
                else
                {
                    LogDebug("✗ Sage300 connection test failed");
                }
            }
            catch (Exception ex)
            {
                LogDebug($"Test workflow failed: {ex.Message}");
            }
        }
    }
}
