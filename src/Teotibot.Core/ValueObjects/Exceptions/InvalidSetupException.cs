using System;
using System.Runtime.Serialization;

namespace Teotibot.Core.ValueObjects.Exceptions
{
    public class InvalidSetupException : Exception
    {
        public InvalidSetupException()
        {
        }

        public InvalidSetupException(string message) : base(message)
        {
        }

        public InvalidSetupException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSetupException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
