using System;

namespace ElginOeIntegration.Models
{
    public class WoolworthsConfig
    {
        public string SiteUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StoragePath { get; set; } = "./downloads";

        public void ValidateConfiguration()
        {
            if (string.IsNullOrEmpty(SiteUrl))
                throw new InvalidOperationException("Site URL is not configured");
            
            if (string.IsNullOrEmpty(Username))
                throw new InvalidOperationException("Username is not configured");
            
            if (string.IsNullOrEmpty(Password))
                throw new InvalidOperationException("Password is not configured");
        }
    }
}
