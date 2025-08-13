using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Models;
using ElginOeIntegration.Exceptions;
using ACCPAC.Advantage;

namespace ElginOeIntegration.Models
{
    public class OeOrderHeader
    {
        public string OrderNumber { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequestedShipDate { get; set; }
        public string ShipViaCode { get; set; }
        public string TermsCode { get; set; }
        public string SalespersonCode { get; set; }
        public string Reference { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; } = "ZAR";
        public List<OeOrderDetail> OrderDetails { get; set; } = new List<OeOrderDetail>();
    }

    public class OeOrderDetail
    {
        public int LineNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Location { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice { get; set; }
        public DateTime RequestedShipDate { get; set; }
        public string Comments { get; set; }
    }

    public class OeImportData
    {
        public List<OeOrderHeader> Orders { get; set; } = new List<OeOrderHeader>();
        public string BatchId { get; set; }
        public DateTime ImportDate { get; set; } = DateTime.Now;
        public string Source { get; set; } = "Woolworths Integration";
    }
}

namespace ElginOeIntegration.Services
{
    public interface ISage300OeService : ISage300Service
    {
        Task<Sage300ImportResult> ImportOrdersAsync(OeImportData orderData);
        Task<Sage300ImportResult> ImportSingleOrderAsync(OeOrderHeader order);
        Task<bool> ValidateCustomerAsync(string customerCode);
        Task<bool> ValidateItemAsync(string itemCode);
        Task<string> GetNextOrderNumberAsync();
    }

    public class Sage300OeService : Sage300Service, ISage300OeService
    {
        protected View OEORD1header;
        protected ViewFields OEORD1headerFields;

        protected View OEORD1detail1;
        protected ViewFields OEORD1detail1Fields;


        public Sage300OeService(Sage300Config config) : base(config)
        {
            LogInfo("Initializing Sage300 OE Service");
        }


        public bool Init()
        {
            OEORD1header = mDBLinkCmpRW.OpenView("OE0520");
            OEORD1headerFields = OEORD1header.Fields;

            OEORD1detail1 = mDBLinkCmpRW.OpenView("OE0500");
            OEORD1detail1Fields = OEORD1detail1.Fields;



            // TODO: To increase efficiency, comment out any unused DB links.
            // Dim mDBLinkCmpRW As AccpacCOMAPI.AccpacDBLink
            //Set mDBLinkCmpRW = OpenDBLink(DBLINK_COMPANY, DBLINK_FLG_READWRITE)

            //Dim mDBLinkSysRW As AccpacCOMAPI.AccpacDBLink
            //Set mDBLinkSysRW = OpenDBLink(DBLINK_SYSTEM, DBLINK_FLG_READWRITE)

            //Dim temp As Boolean
            //Dim OEORD1header As AccpacCOMAPI.AccpacView
            //Dim OEORD1headerFields As AccpacCOMAPI.AccpacViewFields
            //mDBLinkCmpRW.OpenView "OE0520", OEORD1header
            //Set OEORD1headerFields = OEORD1header.Fields

//Dim OEORD1detail1 As AccpacCOMAPI.AccpacView
//Dim OEORD1detail1Fields As AccpacCOMAPI.AccpacViewFields
//mDBLinkCmpRW.OpenView "OE0500", OEORD1detail1
//Set OEORD1detail1Fields = OEORD1detail1.Fields

Dim OEORD1detail2 As AccpacCOMAPI.AccpacView
Dim OEORD1detail2Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0740", OEORD1detail2
Set OEORD1detail2Fields = OEORD1detail2.Fields

Dim OEORD1detail3 As AccpacCOMAPI.AccpacView
Dim OEORD1detail3Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0180", OEORD1detail3
Set OEORD1detail3Fields = OEORD1detail3.Fields

Dim OEORD1detail4 As AccpacCOMAPI.AccpacView
Dim OEORD1detail4Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0526", OEORD1detail4
Set OEORD1detail4Fields = OEORD1detail4.Fields

Dim OEORD1detail5 As AccpacCOMAPI.AccpacView
Dim OEORD1detail5Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0522", OEORD1detail5
Set OEORD1detail5Fields = OEORD1detail5.Fields

Dim OEORD1detail6 As AccpacCOMAPI.AccpacView
Dim OEORD1detail6Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0508", OEORD1detail6
Set OEORD1detail6Fields = OEORD1detail6.Fields

Dim OEORD1detail7 As AccpacCOMAPI.AccpacView
Dim OEORD1detail7Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0507", OEORD1detail7
Set OEORD1detail7Fields = OEORD1detail7.Fields

Dim OEORD1detail8 As AccpacCOMAPI.AccpacView
Dim OEORD1detail8Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0501", OEORD1detail8
Set OEORD1detail8Fields = OEORD1detail8.Fields

Dim OEORD1detail9 As AccpacCOMAPI.AccpacView
Dim OEORD1detail9Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0502", OEORD1detail9
Set OEORD1detail9Fields = OEORD1detail9.Fields

Dim OEORD1detail10 As AccpacCOMAPI.AccpacView
Dim OEORD1detail10Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0504", OEORD1detail10
Set OEORD1detail10Fields = OEORD1detail10.Fields

Dim OEORD1detail11 As AccpacCOMAPI.AccpacView
Dim OEORD1detail11Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0506", OEORD1detail11
Set OEORD1detail11Fields = OEORD1detail11.Fields

Dim OEORD1detail12 As AccpacCOMAPI.AccpacView
Dim OEORD1detail12Fields As AccpacCOMAPI.AccpacViewFields
mDBLinkCmpRW.OpenView "OE0503", OEORD1detail12
Set OEORD1detail12Fields = OEORD1detail12.Fields

                return true;
        }


        public override async Task<Sage300ImportResult> ImportDataAsync<T>(T data)
        {
            if (data is OeImportData oeData)
            {
                return await ImportOrdersAsync(oeData);
            }
            else if (data is OeOrderHeader orderHeader)
            {
                return await ImportSingleOrderAsync(orderHeader);
            }
            else
            {
                throw new Sage300ImportException($"Unsupported data type for OE import: {typeof(T).Name}");
            }
        }

        public async Task<Sage300ImportResult> ImportOrdersAsync(OeImportData orderData)
        {
            if (!_isConnected)
            {
                await ConnectAsync();
            }

            try
            {
                LogInfo($"Starting import of {orderData.Orders.Count} orders from batch {orderData.BatchId}");

                var result = new Sage300ImportResult
                {
                    RecordsProcessed = orderData.Orders.Count,
                    RecordsSuccessful = 0,
                    RecordsFailed = 0
                };

                foreach (var order in orderData.Orders)
                {
                    try
                    {
                        var orderResult = await ProcessSingleOrderAsync(order);
                        
                        if (orderResult.Success)
                        {
                            result.RecordsSuccessful++;
                            LogDebug($"Successfully imported order {order.OrderNumber}");
                        }
                        else
                        {
                            result.RecordsFailed++;
                            result.FailedRecords.Add($"Order {order.OrderNumber}: {orderResult.Message}");
                            result.Errors.AddRange(orderResult.Errors);
                            LogError($"Failed to import order {order.OrderNumber}: {orderResult.Message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        result.RecordsFailed++;
                        result.FailedRecords.Add($"Order {order.OrderNumber}: {ex.Message}");
                        result.Errors.Add($"Exception processing order {order.OrderNumber}: {ex.Message}");
                        LogError($"Exception processing order {order.OrderNumber}: {ex.Message}");
                    }
                }

                result.Success = result.RecordsFailed == 0;
                result.Message = result.Success 
                    ? $"Successfully imported {result.RecordsSuccessful} orders"
                    : $"Imported {result.RecordsSuccessful} orders, {result.RecordsFailed} failed";

                LogInfo($"Import completed: {result.Message}");
                return result;
            }
            catch (Exception ex)
            {
                LogError($"Critical error during order import: {ex.Message}");
                return CreateFailureResult($"Critical error during import: {ex.Message}", ex);
            }
        }

        public async Task<Sage300ImportResult> ImportSingleOrderAsync(OeOrderHeader order)
        {
            if (!_isConnected)
            {
                await ConnectAsync();
            }

            try
            {
                LogDebug($"Importing single order {order.OrderNumber}");
                return await ProcessSingleOrderAsync(order);
            }
            catch (Exception ex)
            {
                LogError($"Error importing single order {order.OrderNumber}: {ex.Message}");
                return CreateFailureResult($"Failed to import order {order.OrderNumber}: {ex.Message}", ex);
            }
        }

        private async Task<Sage300ImportResult> ProcessSingleOrderAsync(OeOrderHeader order)
        {
            try
            {
                // Validate order data
                var validationResult = await ValidateOrderAsync(order);
                if (!validationResult.Success)
                {
                    return validationResult;
                }

                // Generate order number if not provided
                if (string.IsNullOrEmpty(order.OrderNumber))
                {
                    order.OrderNumber = await GetNextOrderNumberAsync();
                }

                // TODO: Replace with actual Sage300 OE SDK calls
                // Example Sage300 OE import logic:
                // 1. Open OE Order Entry batch
                // 2. Create order header
                // 3. Add order details
                // 4. Validate and post

                await SimulateOrderImport(order);

                LogDebug($"Successfully processed order {order.OrderNumber} with {order.OrderDetails.Count} line items");
                
                return CreateSuccessResult(1, $"Order {order.OrderNumber} imported successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error processing order {order.OrderNumber}: {ex.Message}");
                return CreateFailureResult($"Failed to process order {order.OrderNumber}: {ex.Message}", ex);
            }
        }

        private async Task<Sage300ImportResult> ValidateOrderAsync(OeOrderHeader order)
        {
            var errors = new List<string>();

            // Basic validation
            if (string.IsNullOrEmpty(order.CustomerCode))
                errors.Add("Customer code is required");

            if (order.OrderDate == DateTime.MinValue)
                errors.Add("Order date is required");

            if (order.OrderDetails == null || !order.OrderDetails.Any())
                errors.Add("Order must have at least one line item");

            // Validate customer exists
            if (!string.IsNullOrEmpty(order.CustomerCode))
            {
                var customerExists = await ValidateCustomerAsync(order.CustomerCode);
                if (!customerExists)
                    errors.Add($"Customer {order.CustomerCode} not found in Sage300");
            }

            // Validate items exist
            foreach (var detail in order.OrderDetails ?? new List<OeOrderDetail>())
            {
                if (string.IsNullOrEmpty(detail.ItemCode))
                {
                    errors.Add($"Item code is required for line {detail.LineNumber}");
                    continue;
                }

                var itemExists = await ValidateItemAsync(detail.ItemCode);
                if (!itemExists)
                    errors.Add($"Item {detail.ItemCode} not found in Sage300");

                if (detail.Quantity <= 0)
                    errors.Add($"Quantity must be greater than 0 for line {detail.LineNumber}");
            }

            if (errors.Any())
            {
                var result = CreateFailureResult($"Order validation failed: {string.Join("; ", errors)}");
                result.Errors.AddRange(errors);
                return result;
            }

            return CreateSuccessResult(0, "Order validation passed");
        }

        public async Task<bool> ValidateCustomerAsync(string customerCode)
        {
            try
            {
                LogDebug($"Validating customer {customerCode}");
                
                // TODO: Replace with actual Sage300 customer validation
                // Example: var customer = oeSession.Customers.Find(customerCode);
                await Task.Delay(100); // Simulate lookup time

                // For demo purposes, assume customer exists if code is not empty
                return !string.IsNullOrEmpty(customerCode);
            }
            catch (Exception ex)
            {
                LogError($"Error validating customer {customerCode}: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> ValidateItemAsync(string itemCode)
        {
            try
            {
                LogDebug($"Validating item {itemCode}");
                
                // TODO: Replace with actual Sage300 item validation
                // Example: var item = icSession.Items.Find(itemCode);
                await Task.Delay(50); // Simulate lookup time

                // For demo purposes, assume item exists if code is not empty
                return !string.IsNullOrEmpty(itemCode);
            }
            catch (Exception ex)
            {
                LogError($"Error validating item {itemCode}: {ex.Message}");
                return false;
            }
        }

        public async Task<string> GetNextOrderNumberAsync()
        {
            try
            {
                LogDebug("Getting next order number");
                
                // TODO: Replace with actual Sage300 order number generation
                // Example: var nextNumber = oeSession.GetNextOrderNumber();
                await Task.Delay(100); // Simulate lookup time

                // For demo purposes, generate a simple order number
                var orderNumber = $"WW{DateTime.Now:yyyyMMdd}{DateTime.Now.Ticks % 10000:D4}";
                
                LogDebug($"Generated order number: {orderNumber}");
                return orderNumber;
            }
            catch (Exception ex)
            {
                LogError($"Error getting next order number: {ex.Message}");
                throw new Sage300ImportException($"Failed to generate order number: {ex.Message}", ex);
            }
        }

        private async Task SimulateOrderImport(OeOrderHeader order)
        {
            // Simulate the time it takes to import an order
            LogDebug($"Simulating import of order {order.OrderNumber}...");
            await Task.Delay(500 + (order.OrderDetails.Count * 100)); // Simulate processing time
            LogDebug($"Simulated import completed for order {order.OrderNumber}");
        }

        public override async Task DisposeAsync()
        {
            LogInfo("Disposing Sage300 OE Service");
            await base.DisposeAsync();
        }
    }
}
