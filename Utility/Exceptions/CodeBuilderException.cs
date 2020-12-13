using System;
using System.Runtime.Serialization;

namespace DevelApp.Utility.Exceptions
{
    [Serializable]
    public class CodeBuilderException : Exception
    {
        public CodeBuilderException()
        {
        }

        public CodeBuilderException(string message) : base(message)
        {
        }

        public CodeBuilderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CodeBuilderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}