using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public class NoNecesitaDesempateException : Exception
    {
        public NoNecesitaDesempateException() :base("No necesita desempate")
        {
        }

        public NoNecesitaDesempateException(string message) : base(message)
        {
        }

        public NoNecesitaDesempateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
