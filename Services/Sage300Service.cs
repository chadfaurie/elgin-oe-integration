using ElginOeIntegration.Exceptions;
using ElginOeIntegration.Models;
using System;
using System.Threading.Tasks;
using ACCPAC.Advantage;
using System.Collections.Generic;

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
        Sage300ConnectionInfo GetConnectionInfo();
    }

    public abstract class Sage300Service : ISage300Service
    {
        protected readonly Sage300Config _config;
        protected Sage300ConnectionInfo _connectionInfo;
        protected bool _isConnected = false;

        private Session _session;
        private DBLink _mDBLinkCmpRW;

        public Session Session
        {
            get
            {
                if(!_isConnected)
                {
                    throw new InvalidOperationException("Session is not connected. Please call ConnectAsync() first.");
                }

                return _session;
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        public DBLink mDBLinkCmpRW
#pragma warning restore IDE1006 // Naming Styles
        {
            get
            {
                if(!_isConnected)
                {
                    throw new InvalidOperationException("Company DBLink is not connected. Please call ConnectAsync() first.");
                }

                return _mDBLinkCmpRW;
            }
        }

        public DBLink CompanyDBLink
        {
            get => this.mDBLinkCmpRW;
        }

        protected Sage300Service(Sage300Config config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _config.ValidateConfiguration();
            
            _connectionInfo = new Sage300ConnectionInfo
            {
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

        public virtual async Task<bool> ConnectAsync()
        {
            try
            {
                LogDebug("Attempting to connect to Sage300...");

                _session = new Session();

                var initd = _session.Init("", "XY", "XY1000", _config.Version);

                //if (!initd)
                //{
                //    throw new Sage300ConnectionException("Failed to initialize Sage300 session.");
                //}
                

                foreach (Organization org in _session.Organizations)
                {
                    Console.WriteLine("Company ID: [" + org.ID + "] Name: \"" +
                        org.Name + "\" Type: " + org.Type);
                }

                _session.Open(_config.UserId, _config.Password, _config.CompanyId, DateTime.Today, 0);
                _mDBLinkCmpRW = _session.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadWrite);

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
                throw new Sage300ConnectionException($"Connection failed: {ex.Message ?? ex.InnerException.Message}", ex);
            }
        }

        public virtual async Task DisconnectAsync()
        {
            try
            {
                if (_isConnected)
                {
                    LogDebug("Disconnecting from Sage300...");

                    _session.Dispose();
                    _session = null;

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
