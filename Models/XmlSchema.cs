using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ElginOeIntegration.Models
{
    [XmlRoot("Schema")]
    public class Schema
    {
        [XmlElement("PlanDownload")]
        public PlanDownload PlanDownload { get; set; }
    }

    public class PlanDownload
    {
        [XmlElement("PlanDetail")]
        public List<PlanDetail> PlanDetail { get; set; } = new List<PlanDetail>();
    }

    public class PlanDetail
    {
        [XmlElement("TraySize")]
        public string TraySize { get; set; }

        [XmlElement("ProductCode")]
        public string ProductCode { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

        [XmlElement("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [XmlElement("SupplierCode")]
        public string SupplierCode { get; set; }

        [XmlElement("Region")]
        public string Region { get; set; }

        [XmlElement("Department")]
        public string Department { get; set; }
    }
}
