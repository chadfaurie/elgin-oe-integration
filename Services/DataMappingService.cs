using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Models;

namespace ElginOeIntegration.Services
{
    public interface IDataMappingService
    {
        Task<OeImportData> MapPlanDownloadToOeOrdersAsync(PlanDownload planDownload);
        Task<OeOrderHeader> MapPlanDetailToOrderAsync(IGrouping<DateTime, PlanDetail> groupedDetails);
        Task<OeOrderDetail> MapPlanDetailToOrderDetailAsync(PlanDetail planDetail, int lineNumber);
    }

    public class DataMappingService : IntegrationService, IDataMappingService
    {
        public async Task<OeImportData> MapPlanDownloadToOeOrdersAsync(PlanDownload planDownload)
        {
            LogInfo($"Starting mapping of {planDownload.PlanDetail.Count} plan details to OE orders");

            var importData = new OeImportData
            {
                BatchId = $"WW_{DateTime.Now:yyyyMMdd_HHmmss}",
                ImportDate = DateTime.Now,
                Source = "Woolworths Plan Download"
            };

            try
            {
                // Group plan details by supplier code to create separate orders per supplier
                var groupedBySupplier = planDownload.PlanDetail
                    .Where(p => !string.IsNullOrEmpty(p.ProductSKU))
                    .GroupBy(p => p.ProductSKU);

                foreach (var supplierGroup in groupedBySupplier)
                {
                    // Further group by delivery date (parsed from IntoDCDate) to create separate orders per delivery date
                    var groupedByDate = supplierGroup
                        .Where(p => !string.IsNullOrEmpty(p.IntoDCDate))
                        .GroupBy(p => DateTime.Parse(p.IntoDCDate));

                    foreach (var dateGroup in groupedByDate)
                    {
                        var order = await MapPlanDetailToOrderAsync(dateGroup);
                        importData.Orders.Add(order);
                    }
                }

                LogInfo($"Mapped {planDownload.PlanDetail.Count} plan details to {importData.Orders.Count} orders");
                return importData;
            }
            catch (Exception ex)
            {
                LogDebug($"Error during mapping: {ex.Message}");
                throw new InvalidOperationException($"Failed to map plan download to OE orders: {ex.Message}", ex);
            }
        }

        public async Task<OeOrderHeader> MapPlanDetailToOrderAsync(IGrouping<DateTime, PlanDetail> groupedDetails)
        {
            var firstDetail = groupedDetails.First();
            var deliveryDate = DateTime.Parse(firstDetail.IntoDCDate);
            var supplierCode = firstDetail.ProductSKU;

            LogDebug($"Mapping order for supplier {supplierCode} with delivery date {deliveryDate:yyyy-MM-dd}");

            var order = new OeOrderHeader
            {
                // Order will get number from Sage300
                OrderNumber = string.Empty,
                CustomerCode = MapSupplierToCustomer(supplierCode),
                CustomerName = GetCustomerName(supplierCode),
                OrderDate = DateTime.Now,
                RequestedShipDate = deliveryDate,
                ShipViaCode = "STANDARD",
                TermsCode = "NET30",
                SalespersonCode = "SYSTEM",
                Reference = $"Woolworths Plan - {supplierCode}",
                SpecialInstructions = $"Delivery Date: {deliveryDate:yyyy-MM-dd}, Department: {firstDetail.DepartmentName}, Region: {firstDetail.Region}",
                Currency = "ZAR",
                OrderDetails = new List<OeOrderDetail>()
            };

            // Map order details
            int lineNumber = 1;
            foreach (var detail in groupedDetails)
            {
                var orderDetail = await MapPlanDetailToOrderDetailAsync(detail, lineNumber);
                order.OrderDetails.Add(orderDetail);
                lineNumber++;
            }

            // Calculate total amount
            order.TotalAmount = order.OrderDetails.Sum(d => d.ExtendedPrice);

            LogDebug($"Created order for supplier {supplierCode} with {order.OrderDetails.Count} line items, total: {order.TotalAmount:C}");

            return order;
        }

        public async Task<OeOrderDetail> MapPlanDetailToOrderDetailAsync(PlanDetail planDetail, int lineNumber)
        {
            await Task.Delay(1); // Async placeholder

            var orderDetail = new OeOrderDetail
            {
                LineNumber = lineNumber,
                ItemCode = MapProductCodeToItemCode(planDetail.ProductSKU),
                ItemDescription = planDetail.ProductName,
                Location = MapRegionToLocation(planDetail.Region),
                Quantity = planDetail.Quantity,
                UnitOfMeasure = DetermineUnitOfMeasure(planDetail.TraySize),
                UnitPrice = 0, // Will be populated from Sage300 item master
                ExtendedPrice = 0, // Will be calculated after unit price is determined
                RequestedShipDate = DateTime.TryParse(planDetail.IntoDCDate, out var dt) ? dt : DateTime.MinValue,
                Comments = !string.IsNullOrEmpty(planDetail.TraySize) ? $"Tray Size: {planDetail.TraySize}" : string.Empty
            };

            return orderDetail;
        }

        private string MapSupplierToCustomer(string supplierCode)
        {
            // Map Woolworths supplier codes to Sage300 customer codes
            // This would typically come from a configuration file or database mapping
            var supplierMapping = new Dictionary<string, string>
            {
                { "54506", "WOOLWORTHS" },
                { "WOOLWORTHS", "WOOLWORTHS" }
            };

            return supplierMapping.TryGetValue(supplierCode, out var customerCode) ? customerCode : supplierCode;
        }

        private string GetCustomerName(string supplierCode)
        {
            // Get customer name based on supplier code
            var customerNames = new Dictionary<string, string>
            {
                { "54506", "Woolworths Holdings Limited" },
                { "WOOLWORTHS", "Woolworths Holdings Limited" }
            };

            return customerNames.TryGetValue(supplierCode, out var name) ? name : $"Customer {supplierCode}";
        }

        private string MapProductCodeToItemCode(string productCode)
        {
            // Map Woolworths product codes to internal item codes
            // This would typically come from a product mapping table
            if (string.IsNullOrEmpty(productCode))
                return "UNKNOWN";

            // For now, just clean up the product code
            return productCode.Trim().ToUpperInvariant();
        }

        private string MapRegionToLocation(string region)
        {
            // Map Woolworths regions to Sage300 locations
            var regionMapping = new Dictionary<string, string>
            {
                { "GAUTENG", "JHB" },
                { "WESTERN CAPE", "CPT" },
                { "KWAZULU-NATAL", "DBN" },
                { "EASTERN CAPE", "PE" },
                { "FREE STATE", "BFN" },
                { "LIMPOPO", "PLK" },
                { "MPUMALANGA", "NEL" },
                { "NORTH WEST", "MMB" },
                { "NORTHERN CAPE", "KIM" }
            };

            if (string.IsNullOrEmpty(region))
                return "MAIN";

            var regionKey = region.ToUpperInvariant();
            return regionMapping.TryGetValue(regionKey, out var location) ? location : "MAIN";
        }

        private string DetermineUnitOfMeasure(string traySize)
        {
            // Determine unit of measure based on tray size
            if (string.IsNullOrEmpty(traySize))
                return "EACH";

            var trayUpper = traySize.ToUpperInvariant();

            if (trayUpper.Contains("CASE") || trayUpper.Contains("CTN"))
                return "CASE";

            if (trayUpper.Contains("BOX"))
                return "BOX";

            if (trayUpper.Contains("TRAY"))
                return "TRAY";

            // Try to parse if it's a number (indicating pack size)
            if (int.TryParse(traySize, out var packSize))
            {
                return packSize > 1 ? "PACK" : "EACH";
            }

            return "EACH";
        }
    }
}
