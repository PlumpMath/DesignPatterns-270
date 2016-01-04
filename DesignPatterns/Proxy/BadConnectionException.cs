using System;

namespace Proxy
{
    class BadConnectionException : Exception
    {
        public BadConnectionException(string message)
            : base(message)
        {
        }
    }
}