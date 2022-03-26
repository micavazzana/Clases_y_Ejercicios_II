using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClases
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder sb = new StringBuilder();

            do
            {
                if (numeroEntero % 2 == 0)
                {
                    sb.Insert(0,"0");
                }
                else
                {
                    sb.Insert(0,"1");
                }
                numeroEntero = numeroEntero / 2;
            } while (numeroEntero != 0);
            return sb.ToString(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns></returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string strNumero = numeroEntero.ToString();
            int largoCadena = strNumero.Length - 1;
            int acumulador = 0;

            foreach (char item in strNumero)
            {
                if (item  == '1')
                {
                    acumulador += (int)Math.Pow(2, largoCadena);
                }//si es 0 solo acumularia 0 asi que no hago nada
                largoCadena--;
            }
            return acumulador;
        }
    }
}
