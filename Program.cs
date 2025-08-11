using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using ElginOeIntegration.Models;
using ElginOeIntegration.Services;
using ElginOeIntegration.Utils;

namespace ElginOeIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();

            /*Register Configurations*/
            var woolworthsConfig = new WoolworthsConfig
            {
                // Set properties as needed, e.g.:
                SiteUrl = "http://caissanet.woolworths.co.za/WebClients/SPort/Login.aspx?ReturnUrl=%2fWebClients%2fSPort%2fSupplierPlansJDAReport.aspx&__CFW_AuthFailed=True",
                Username = "s54506_010",
                Password = "Elgin2020f",
                StoragePath = ".downloads"
                // SiteName = "Woolworths"
            };
            container.RegisterInstance(woolworthsConfig);

            var sage300Config = new Sage300Config
            {
                ServerName = "localhost",
                DatabaseId = "SAMLTD",
                UserId = "ADMIN",
                Password = "password",
                Version = "68A"
            };
            container.RegisterInstance(sage300Config);

            // Register dependencies
            container.Register<IWoolworthsScraperService, WoolworthsScraperService>();
            container.Register<IXmlExtractorService, XmlExtractorService>();
            container.Register<IDataMappingService, DataMappingService>();
            //container.Register<ISage300OeService, Sage300OeService>();

            container.Register<IFullIntegrationWorkflow, FullIntegrationWorkflow>();

            // Optionally verify
            container.Verify();

            // Resolve and use
            var service = container.GetInstance<IFullIntegrationWorkflow>();

            service.RunCompleteWorkflowAsync().GetAwaiter().GetResult();
        }
    }
}