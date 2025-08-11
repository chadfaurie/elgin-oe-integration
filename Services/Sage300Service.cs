using System;
using System.Threading.Tasks;
using ElginOeIntegration.Models;
using ElginOeIntegration.Exceptions;

namespace ElginOeIntegration.Exceptions
{
    public class Sage300ConnectionException : Exception
    {
        public Sage300ConnectionException(string message) : base(message)
        {
        }

        public Sage300ConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class Sage300ImportException : Exception
    {
        public Sage300ImportException(string message) : base(message)
        {
        }

        public Sage300ImportException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

namespace ElginOeIntegration.Services
{
    public interface ISage300Service
    {
        Task<bool> ConnectAsync();
        Task DisconnectAsync();
        Task<Sage300ImportResult> ImportDataAsync<T>(T data) where T : class;
        Task<bool> TestConnectionAsync();
        Sage300ConnectionInfo GetConnectionInfo();
    }

    public abstract class Sage300Service : ISage300Service
    {
        protected readonly Sage300Config _config;
        protected Sage300ConnectionInfo _connectionInfo;
        protected bool _isConnected = false;

        protected Sage300Service(Sage300Config config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _config.ValidateConfiguration();
            
            _connectionInfo = new Sage300ConnectionInfo
            {
                ConnectionString = BuildConnectionString(),
                IsConnected = false,
                LastConnectionTime = DateTime.MinValue
            };
        }

        protected void LogDebug(string message)
        {
            Console.WriteLine($"[DEBUG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        protected void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        protected void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetType().Name}: {message}");
        }

        protected virtual string BuildConnectionString()
        {
            // Basic connection string format - this would need to be adapted based on actual Sage300 SDK
            return $"Server={_config.ServerName};Database={_config.DatabaseId};UserId={_config.UserId};Password={_config.Password};Version={_config.Version};Timeout={_config.ConnectionTimeout}";
        }

        public virtual async Task<bool> ConnectAsync()
        {
            try
            {
                LogDebug("Attempting to connect to Sage300...");

                // This is where you would use the actual Sage300 SDK connection logic
                // For now, we'll simulate the connection
                await Task.Delay(1000); // Simulate connection time

                // TODO: Replace with actual Sage300 SDK connection code
                // Example: var session = new Sage300Session();
                // session.Connect(_connectionInfo.ConnectionString);

                _isConnected = true;
                _connectionInfo.IsConnected = true;
                _connectionInfo.LastConnectionTime = DateTime.Now;
                _connectionInfo.LastError = null;

                LogInfo("Successfully connected to Sage300");
                return true;
            }
            catch (Exception ex)
            {
                _isConnected = false;
                _connectionInfo.IsConnected = false;
                _connectionInfo.LastError = ex.Message;
                
                LogError($"Failed to connect to Sage300: {ex.Message}");
                throw new Sage300ConnectionException($"Connection failed: {ex.Message}", ex);
            }
        }

        public virtual async Task DisconnectAsync()
        {
            try
            {
                if (_isConnected)
                {
                    LogDebug("Disconnecting from Sage300...");

                    // TODO: Replace with actual Sage300 SDK disconnection code
                    // Example: session.Disconnect();
                    await Task.Delay(500); // Simulate disconnection time

                    _isConnected = false;
                    _connectionInfo.IsConnected = false;
                    
                    LogInfo("Successfully disconnected from Sage300");
                }
            }
            catch (Exception ex)
            {
                LogError($"Error during disconnection: {ex.Message}");
                // Don't throw on disconnect errors, just log them
            }
        }

        public virtual async Task<bool> TestConnectionAsync()
        {
            try
            {
                LogDebug("Testing Sage300 connection...");
                
                var wasConnected = _isConnected;
                
                if (!_isConnected)
                {
                    await ConnectAsync();
                }

                // TODO: Perform actual connection test
                // Example: var result = session.TestConnection();
                await Task.Delay(500); // Simulate test

                if (!wasConnected)
                {
                    await DisconnectAsync();
                }

                LogInfo("Connection test successful");
                return true;
            }
            catch (Exception ex)
            {
                LogError($"Connection test failed: {ex.Message}");
                return false;
            }
        }

        public Sage300ConnectionInfo GetConnectionInfo()
        {
            return _connectionInfo;
        }

        public abstract Task<Sage300ImportResult> ImportDataAsync<T>(T data) where T : class;

        protected virtual Sage300ImportResult CreateSuccessResult(int recordsProcessed, string message = "Import completed successfully")
        {
            return new Sage300ImportResult
            {
                Success = true,
                Message = message,
                RecordsProcessed = recordsProcessed,
                RecordsSuccessful = recordsProcessed,
                RecordsFailed = 0
            };
        }

        protected virtual Sage300ImportResult CreateFailureResult(string message, Exception ex = null)
        {
            var result = new Sage300ImportResult
            {
                Success = false,
                Message = message,
                RecordsProcessed = 0,
                RecordsSuccessful = 0,
                RecordsFailed = 0
            };

            result.Errors.Add(message);
            
            if (ex != null)
            {
                result.Errors.Add($"Exception: {ex.Message}");
            }

            return result;
        }

        // Virtual dispose pattern for cleanup
        public virtual async Task DisposeAsync()
        {
            await DisconnectAsync();
        }
    }
}
