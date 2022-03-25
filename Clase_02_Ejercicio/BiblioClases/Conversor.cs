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

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string strNumero = numeroEntero.ToString();
            int largoCadena = strNumero.Length;
            double resultadoExp;
            double conv = 0;

            foreach (char item in strNumero)
            {
                resultadoExp = Math.Pow(2, largoCadena - 1);
                if (item  == '1')
                {
                    conv += resultadoExp * 1;
                   
                }
                if (item == '0')
                {
                    conv += resultadoExp * 0;
                }
                largoCadena--;
            }
            return (int)conv;
        }
    }
}
