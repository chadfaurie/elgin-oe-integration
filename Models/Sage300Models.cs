using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ElginOeIntegration.Models
{
    public class Sage300Config
    {
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Version { get; set; } = "68A";
        public int ConnectionTimeout { get; set; } = 30;

        public void ValidateConfiguration()
        { 
            if (string.IsNullOrEmpty(CompanyId))
                throw new InvalidOperationException("Company ID is required for Sage300 connection");
            
            if (string.IsNullOrEmpty(UserId))
                throw new InvalidOperationException("User ID is required for Sage300 connection");
            
            if (string.IsNullOrEmpty(Password))
                throw new InvalidOperationException("Password is required for Sage300 connection");
        }
    }

    public class Sage300ConnectionInfo
    {
        public bool IsConnected { get; set; }
        public DateTime LastConnectionTime { get; set; }
        public string LastError { get; set; }
    }

    public abstract class Sage300Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public DateTime ProcessedAt { get; set; } = DateTime.Now;
    }

    public class Sage300ImportResult : Sage300Result
    {
        public int RecordsProcessed { get; set; }
        public int RecordsSuccessful { get; set; }
        public int RecordsFailed { get; set; }
        public List<string> FailedRecords { get; set; } = new List<string>();
    }
}
