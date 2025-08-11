using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElginOeIntegration
{
    public abstract class IntegrationService
    {
        protected void LogDebug(string message)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }
    }
}
