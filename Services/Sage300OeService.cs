using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElginOeIntegration.Models;
using ElginOeIntegration.Exceptions;
using ACCPAC.Advantage;

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

        protected View OEORD1detail2;
        protected ViewFields OEORD1detail2Fields;

        protected View OEORD1detail3;
        protected ViewFields OEORD1detail3Fields;

        protected View OEORD1detail4;
        protected ViewFields OEORD1detail4Fields;

        protected View OEORD1detail5;
        protected ViewFields OEORD1detail5Fields;

        protected View OEORD1detail6;
        protected ViewFields OEORD1detail6Fields;

        protected View OEORD1detail7;
        protected ViewFields OEORD1detail7Fields;

        protected View OEORD1detail8;
        protected ViewFields OEORD1detail8Fields;

        protected View OEORD1detail9;
        protected ViewFields OEORD1detail9Fields;

        protected View OEORD1detail10;
        protected ViewFields OEORD1detail10Fields;

        protected View OEORD1detail11;
        protected ViewFields OEORD1detail11Fields;

        protected View OEORD1detail12;
        protected ViewFields OEORD1detail12Fields;

        public Sage300OeService(Sage300Config config) : base(config)
        {
            LogInfo("Initializing Sage300 OE Service");
        }

        public override void InitializeViews()
        {
            OEORD1header = mDBLinkCmpRW.OpenView("OE0520");
            OEORD1headerFields = OEORD1header.Fields;

            OEORD1detail1 = mDBLinkCmpRW.OpenView("OE0500");
            OEORD1detail1Fields = OEORD1detail1.Fields;

            OEORD1detail2 = mDBLinkCmpRW.OpenView("OE0740");
            OEORD1detail2Fields = OEORD1detail2.Fields;

            OEORD1detail3 = mDBLinkCmpRW.OpenView("OE0180");
            OEORD1detail3Fields = OEORD1detail3.Fields;

            OEORD1detail4 = mDBLinkCmpRW.OpenView("OE0526");
            OEORD1detail4Fields = OEORD1detail4.Fields;

            OEORD1detail5 = mDBLinkCmpRW.OpenView("OE0522");
            OEORD1detail5Fields = OEORD1detail5.Fields;

            OEORD1detail6 = mDBLinkCmpRW.OpenView("OE0508");
            OEORD1detail6Fields = OEORD1detail6.Fields;

            OEORD1detail7 = mDBLinkCmpRW.OpenView("OE0507");
            OEORD1detail7Fields = OEORD1detail7.Fields;

            OEORD1detail8 = mDBLinkCmpRW.OpenView("OE0501");
            OEORD1detail8Fields = OEORD1detail8.Fields;

            OEORD1detail9 = mDBLinkCmpRW.OpenView("OE0502");
            OEORD1detail9Fields = OEORD1detail9.Fields;

            OEORD1detail10 = mDBLinkCmpRW.OpenView("OE0504");
            OEORD1detail10Fields = OEORD1detail10.Fields;

            OEORD1detail11 = mDBLinkCmpRW.OpenView("OE0506");
            OEORD1detail11Fields = OEORD1detail11.Fields;

            OEORD1detail12 = mDBLinkCmpRW.OpenView("OE0503");
            OEORD1detail12Fields = OEORD1detail12.Fields;

            OEORD1header.Compose(new View[] { OEORD1detail1, null, OEORD1detail3, OEORD1detail2, OEORD1detail4, OEORD1detail5 });
            OEORD1detail1.Compose(new View[] { OEORD1header, OEORD1detail8, OEORD1detail12, OEORD1detail9, OEORD1detail6, OEORD1detail7 });
            OEORD1detail2.Compose(new View[] { OEORD1header });
            OEORD1detail3.Compose(new View[] { OEORD1header, OEORD1detail1 });
            OEORD1detail4.Compose(new View[] { OEORD1header });
            OEORD1detail5.Compose(new View[] { OEORD1header });
            OEORD1detail6.Compose(new View[] { OEORD1detail1 });
            OEORD1detail7.Compose(new View[] { OEORD1detail1 });
            OEORD1detail8.Compose(new View[] { OEORD1detail1 });
            OEORD1detail9.Compose(new View[] { OEORD1detail1, OEORD1detail10, OEORD1detail11 });
            OEORD1detail10.Compose(new View[] { OEORD1detail9 });
            OEORD1detail11.Compose(new View[] { OEORD1detail9 });
            OEORD1detail12.Compose(new View[] { OEORD1detail1 });

            LogInfo("Sage300 OE views initialized successfully");
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

                var temp = OEORD1header.Exists;


                OEORD1headerFields.FieldByName("DRIVENBYUI").SetValue("1", false); // Driven by UI
                OEORD1header.Cancel();
                OEORD1header.Init();

                OEORD1detail2.Browse("", true);
                OEORD1detail2.Fetch(false);
                OEORD1headerFields.FieldByName("CUSTOMER").SetValue(order.CustomerCode, true); // Customer Code

                OEORD1detail2.Browse("", true);

                OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
                OEORD1detail2.Browse("", true);
                OEORD1detail2.Fetch(false);

                OEORD1headerFields.FieldByName("PROCESSCMD").SetValue("1", false); // Process OIP Command
                OEORD1header.Process();

                OEORD1headerFields.FieldByName("PONUMBER").SetValue(order.PoNumber, true); // Purchase Order Number
                OEORD1headerFields.FieldByName("REQUESDATE").SetValue(order.RequestDate, true); // Date Requested
                OEORD1headerFields.FieldByName("EXPDATE").SetValue(order.ExpectedShipDate, true); // Expected Ship Date



                // Details
                foreach (var line in order.OrderDetails)
                {
                    temp = OEORD1detail1.Exists;
                    OEORD1detail1.RecordClear();
                    temp = OEORD1detail1.Exists;

                    OEORD1detail1.RecordCreate(ViewRecordCreate.NoInsert);
                    temp = OEORD1detail1.Exists;

                    OEORD1detail1Fields.FieldByName("ITEM").SetValue(line.ItemCode, true); // Item
                    OEORD1detail1Fields.FieldByName("PROCESSCMD").SetValue("1", false); // Process Command

                    OEORD1detail1.Process();
                    temp = OEORD1detail1.Exists;

                    OEORD1detail5.Update();

                    OEORD1detail1Fields.FieldByName("ORDUNIT").SetValue("CRATE", true); // Order Unit of Measure
                    OEORD1detail1Fields.FieldByName("QTYORDERED").SetValue(line.Quantity, true); // Quantity Ordered

                    temp = OEORD1detail1.Exists;
                    OEORD1detail1.Insert();
                    temp = OEORD1detail1.Exists;

                    OEORD1detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

                    OEORD1detail1.Read(true);
                    temp = OEORD1detail1.Exists;


                    OEORD1detail1.RecordCreate(ViewRecordCreate.NoInsert);
                    temp = OEORD1detail1.Exists;

                    OEORD1detail1Fields.FieldByName("LINENUM").SetValue("-1", false); // Line Number

                    OEORD1detail1.Read(true);
                    OEORD1detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

                    OEORD1detail5Fields.FieldByName("OPTFIELD").SetValue("OEPICK", false); // Optional Field

                    OEORD1detail5.Read(true);

                    OEORD1detail5Fields.FieldByName("VALIFBOOL").SetValue("1", true); // Yes/No Value

                    temp = OEORD1detail5.Exists;
                    OEORD1detail5.Update();

                    OEORD1detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

                    OEORD1detail5.Read(true);

                    OEORD1detail5Fields.FieldByName("VALIFTEXT").SetValue("WWTRANS", true); // Text Value

                    OEORD1detail5.Update();

                    OEORD1detail5Fields.FieldByName("OPTFIELD").SetValue("TRUCK", false); // Optional Field

                    OEORD1detail5.Read(true);
                    OEORD1headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command

                    OEORD1headerFields.FieldByName("REFERENCE").SetValue("WW PORTAL", false); // Order Reference
                    OEORD1headerFields.FieldByName("DESC").SetValue("70295363 FOOD WC1", false); // Order Description

                    OEORD1header.Process();
                    OEORD1header.Insert();
                    OEORD1header.Order = 1;
                    OEORD1header.Read(true);
                    OEORD1header.Order = 0;
                    OEORD1detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
                    OEORD1detail1.Browse("", true);
                    OEORD1detail1.Fetch(false);
                    OEORD1detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

                    OEORD1detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

                    OEORD1detail9.Browse("", true);
                    OEORD1detail9.Fetch(false);
                    OEORD1detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
                    OEORD1detail3.Browse("", true);
                    OEORD1detail3.Fetch(false);
                    OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
                    OEORD1detail2.Browse("", false);
                    OEORD1detail2.Fetch(false);

                    OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-1", false); // Payment Number
                    OEORD1detail2.Browse("", true);

                    OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

                    OEORD1detail2.Browse("", false);
                    OEORD1detail2.Fetch(false);
                    temp = OEORD1header.Exists;
                    OEORD1detail1Fields.FieldByName("LINENUM").SetValue("32", false); // Line Number
                    OEORD1detail1.Read(true);
                    OEORD1headerFields.FieldByName("OECOMMAND").SetValue("4", true); // Process O/E Command
                    OEORD1header.Process();
                    temp = OEORD1header.Exists;
                    OEORD1header.Update();
                    OEORD1header.Order = 1;
                    OEORD1header.Read(true);
                    OEORD1header.Order = 0;
                    OEORD1detail1Fields.FieldByName("LINENUM").SetValue("-32767", false); // Line Number
                    OEORD1detail1.Browse("", true);
                    OEORD1detail1.Fetch(false);
                    OEORD1detail9Fields.FieldByName("PRNCOMPNUM").SetValue("-2147483647", false); // Parent Component Number

                    OEORD1detail9Fields.FieldByName("COMPNUM").SetValue("-2147483647", false); // Component Number

                    OEORD1detail9.Browse("", true);
                    OEORD1detail9.Fetch(false);
                    OEORD1detail3Fields.FieldByName("UNIQUIFIER").SetValue("-32767", false); // Uniquifier
                    OEORD1detail3.Browse("", true);
                    OEORD1detail3.Fetch(false);
                    OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number
                    OEORD1detail2.Browse("", false);
                    OEORD1detail2.Fetch(false);
                    OEORD1detail2.Browse("", true);

                    OEORD1detail2Fields.FieldByName("PAYMENT").SetValue("-32767", false); // Payment Number

                    OEORD1detail2.Browse("", false);
                    OEORD1detail2.Fetch(false);
                    temp = OEORD1header.Exists;
                }

                var orderNumber = OEORD1headerFields.FieldByName("").Value.ToString();

                LogDebug($"Successfully processed order {orderNumber} with {order.OrderDetails.Count} line items");

                return CreateSuccessResult(1, $"Order {orderNumber} imported successfully");
            }
            catch (Exception ex)
            {
                LogError($"Error processing order: {ex.Message}");
                return CreateFailureResult($"Error processing order: {ex.Message}", ex);
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



        public override async Task DisposeAsync()
        {
            LogInfo("Disposing Sage300 OE Service");
            await base.DisposeAsync();
        }
    }
}
