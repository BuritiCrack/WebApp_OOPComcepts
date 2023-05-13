using System;
using System.Runtime.Serialization;

namespace WebApp_OOPComcepts
{
    [Serializable]
    internal class MonthExeption : Exception
    {
        public MonthExeption()
        {
        }

        public MonthExeption(string message) : base(message)
        {
        }

        public MonthExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MonthExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}