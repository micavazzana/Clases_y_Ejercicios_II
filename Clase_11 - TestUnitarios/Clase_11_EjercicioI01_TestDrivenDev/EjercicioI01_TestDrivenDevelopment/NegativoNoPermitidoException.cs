using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_TestDrivenDevelopment
{
    public class NegativoNoPermitidoException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public NegativoNoPermitidoException(string message) : base(message)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NegativoNoPermitidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
