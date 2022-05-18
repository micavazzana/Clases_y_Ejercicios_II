using System;

namespace Entidades
{
    public class ArchivoException : Exception
    {
        public ArchivoException(string message) : base(message)
        {
        }

        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
