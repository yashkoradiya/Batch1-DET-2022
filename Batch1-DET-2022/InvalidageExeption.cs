using System.Runtime.Serialization;

namespace ParamsDemo
{
    [Serializable]
    internal class InvalidageExeption : Exception
    {
        internal bool message;

        public InvalidageExeption()
        {
        }

        public InvalidageExeption(string? message) : base(message)
        {
        }

        public InvalidageExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidageExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}