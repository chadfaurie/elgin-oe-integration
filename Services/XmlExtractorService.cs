using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ElginOeIntegration.Exceptions;
using ElginOeIntegration.Models;
using System.Linq;
using System.Collections.Generic;

namespace ElginOeIntegration.Services
{
    public interface IXmlExtractorService
    {
        Task<PlanDownload> ExtractXmlDataAsync(string xmlString);
        void ValidateSchema(Schema schema);
    }

    public class XmlExtractorService : IXmlExtractorService
    {
        protected void LogDebug(string message)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        protected void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        public async Task<PlanDownload> ExtractXmlDataAsync(string xmlString)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(xmlString))
                {
                    throw new XmlExtractionError("XML string cannot be null or empty");
                }

                LogDebug("Starting XML extraction");

                var schema = await Task.Run(() => ParseXmlString(xmlString));
                
                // Validate the schema
                ValidateSchema(schema);

                // Uncomment to debug unique tray sizes
                // var uniqueTraySizes = schema.PlanDownload.PlanDetail
                //     .Select(item => item.TraySize)
                //     .Where(size => !string.IsNullOrEmpty(size))
                //     .Distinct()
                //     .ToList();
                // 
                // LogDebug($"Unique Tray Sizes: {string.Join(", ", uniqueTraySizes)}");

                LogDebug("XML extraction completed successfully");

                return schema.PlanDownload;
            }
            catch (XmlExtractionError)
            {
                throw;
            }
            catch (Exception ex)
            {
                LogError($"Error during XML extraction: {ex.Message}");
                throw new XmlExtractionError($"Failed to extract XML data: {ex.Message}", ex);
            }
        }

        private Schema ParseXmlString(string xmlString)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Schema));
                
                using (var stringReader = new StringReader(xmlString))
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    if (!serializer.CanDeserialize(xmlReader))
                    {
                        throw new XmlExtractionError("XML format is not compatible with expected schema");
                    }

                    var result = (Schema)serializer.Deserialize(xmlReader);
                    return result;
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new XmlExtractionError($"XML deserialization failed: {ex.Message}", ex);
            }
            catch (XmlException ex)
            {
                throw new XmlExtractionError($"Invalid XML format: {ex.Message}", ex);
            }
        }

        public void ValidateSchema(Schema schema)
        {
            if (schema == null)
            {
                throw new XmlExtractionError("Parsed schema is null");
            }

            if (schema.PlanDownload == null)
            {
                throw new XmlExtractionError("PlanDownload element is missing from schema");
            }

            if (schema.PlanDownload.PlanDetail == null)
            {
                throw new XmlExtractionError("PlanDetail collection is missing from schema");
            }

            // Validate individual plan details
            var invalidItems = new List<string>();
            
            for (int i = 0; i < schema.PlanDownload.PlanDetail.Count; i++)
            {
                var item = schema.PlanDownload.PlanDetail[i];
                var errors = new List<string>();

                if (string.IsNullOrWhiteSpace(item.ProductCode))
                    {errors.Add("ProductCode is required");}

                if (string.IsNullOrWhiteSpace(item.Description))
                    {errors.Add("Description is required");}

                if (item.Quantity < 0)
                    {errors.Add("Quantity must be non-negative");}

                if (string.IsNullOrWhiteSpace(item.SupplierCode))
                    {errors.Add("SupplierCode is required");}

                if (errors.Any())
                {
                    invalidItems.Add($"Item {i}: {string.Join(", ", errors)}");
                }
            }

            if (invalidItems.Any())
            {
                throw new XmlExtractionError($"Schema validation failed: {string.Join("; ", invalidItems)}");
            }

            LogDebug($"Schema validation passed. Found {schema.PlanDownload.PlanDetail.Count} plan details");
        }
    }
}
