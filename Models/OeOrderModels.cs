using System;
using System.Collections.Generic;

namespace ElginOeIntegration.Models
{
    public class OeOrderHeader
    {
        public string CustomerCode { get; set; }
        public string PoNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ExpectedShipDate { get; set; }
        public List<OeOrderDetail> OrderDetails { get; set; } = new List<OeOrderDetail>();
        public string Reference { get; set; }
        public string Description { get; set; }
    }

    public class OeOrderDetail
    {
        public string ItemCode { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class OeImportData
    {
        public List<OeOrderHeader> Orders { get; set; } = new List<OeOrderHeader>();
        public string BatchId { get; set; }
        public DateTime ImportDate { get; set; } = DateTime.Now;
        public string Source { get; set; } = "Woolworths Integration";
    }
}
