using System;
using System.Runtime.Serialization;

namespace DevelApp.Utility.Exceptions
{
    [Serializable]
    public class SemanticVersionStringException : Exception
    {
        public SemanticVersionStringException()
        {
        }

        public SemanticVersionStringException(string message) : base(message)
        {
        }

        public SemanticVersionStringException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SemanticVersionStringException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}