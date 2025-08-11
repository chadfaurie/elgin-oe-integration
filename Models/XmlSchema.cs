using Newtonsoft.Json.Linq;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ElginOeIntegration.Models
{
    [XmlRoot("PlanDownload")]
    public class PlanDownload
    {
        [XmlElement("PlanHeader")]
        public PlanHeader PlanHeader { get; set; }

        [XmlElement("PlanDetail")]
        public List<PlanDetail> PlanDetail { get; set; }
    }

    public class PlanDetail
    {
        [XmlElement("RegionId")]
        public int RegionId { get; set; }

        [XmlElement("Region")]
        public string Region { get; set; }

        [XmlElement("DepartmentId")]
        public int DepartmentId { get; set; }

        [XmlElement("DepartmentName")]
        public string DepartmentName { get; set; }

        [XmlElement("ProductID")]
        public int ProductID { get; set; }

        [XmlElement("ProductName")]
        public string ProductName { get; set; }

        [XmlElement("ProductSKU")]
        public string ProductSKU { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

        [XmlElement("Confirmed")]
        public string Confirmed { get; set; }

        [XmlElement("TraySize")]
        public string TraySize { get; set; }

        [XmlElement("IntoDCDate")]
        public string IntoDCDate { get; set; }
    }

    public class PlanHeader
    {
        [XmlElement("PlanDate")]
        public int PlanDate { get; set; }

        [XmlElement("SupplierID")]
        public int SupplierID { get; set; }

        [XmlElement("SupplierName")]
        public string SupplierName { get; set; }

        [XmlElement("SupplyChainType")]
        public string SupplyChainType { get; set; }
    }
}