using System;

namespace Entidades
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) 
            : base(message)
        {
        }
        public ParametrosVaciosException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
