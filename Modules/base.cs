using System;

namespace ElginOeIntegration
{
    public abstract class IntegrationService
    {
        protected void LogDebug(string message)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }
        protected void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }
        protected void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }
    }
}
