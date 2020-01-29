using System;
using System.Runtime.Serialization;

namespace AtlantaCodeCampMobile.Services.Exceptions
{
    public class NetworkConnectivityException : InvalidOperationException
    {
        public NetworkConnectivityException()
        {
        }

        protected NetworkConnectivityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NetworkConnectivityException(string message) : base(message)
        {
        }

        public NetworkConnectivityException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}