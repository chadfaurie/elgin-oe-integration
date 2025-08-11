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

            // Register dependencies
            container.Register<IWoolworthsScraperService, WoolworthsScraperService>();
            container.Register<IXmlExtractorService, XmlExtractorService>();
            container.Register<ISage300OeService, Sage300OeService>();
            container.Register<IDataMappingService, DataMappingService>();

            // Optionally verify
            container.Verify();

            // Resolve and use
            var service = container.GetInstance<IWoolworthsScraperService>();

            service.ScrapeAsync().GetAwaiter().GetResult();
        }
    }
}