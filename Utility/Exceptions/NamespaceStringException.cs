using System;
using System.Runtime.Serialization;

namespace DevelApp.Utility.Exceptions
{
    [Serializable]
    public class NamespaceStringException : Exception
    {
        public NamespaceStringException()
        {
        }

        public NamespaceStringException(string message) : base(message)
        {
        }

        public NamespaceStringException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NamespaceStringException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}