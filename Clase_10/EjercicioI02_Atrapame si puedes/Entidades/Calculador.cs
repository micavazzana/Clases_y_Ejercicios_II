using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculador
    {
        /// <summary>
        /// Divide dos numeros enteros
        /// </summary>
        /// <param name="n1">primer operando</param>
        /// <param name="n2">segundo operando</param>
        /// <returns>Retorna la division entre los dos numeros</returns>
        /// <exception cref="DivideByZeroException">Tira una excepcion al intentar dividir por cero</exception>
        public static float Calcular(int n1, int n2)
        {
            if(n2 == 0)
            {
                throw new DivideByZeroException("no se puede dividir por cero");
            }
            return (float)n1/n2;
        }
    }
}
