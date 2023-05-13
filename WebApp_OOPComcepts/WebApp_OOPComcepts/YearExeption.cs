using System;
using System.Runtime.Serialization;

namespace WebApp_OOPComcepts
{
    [Serializable]
    internal class YearExeption : Exception
    {
        public YearExeption()
        {
        }

        public YearExeption(string message) : base(message)
        {
        }

        public YearExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YearExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}