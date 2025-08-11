using System;

namespace ElginOeIntegration.Exceptions
{
    public class FileReadError : Exception
    {
        public FileReadError(string message) : base(message)
        {
        }

        public FileReadError(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class XmlExtractionError : Exception
    {
        public XmlExtractionError(string message) : base(message)
        {
        }

        public XmlExtractionError(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
