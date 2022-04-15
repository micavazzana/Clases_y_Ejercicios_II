using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numero)
        {
            StringBuilder sb = new StringBuilder();
            int numeroEntero = (int)numero;
            do
            {
                if (numeroEntero % 2 == 0)
                {
                    sb.Insert(0, "0");
                }
                else
                {
                    sb.Insert(0, "1");
                }
                numeroEntero = numeroEntero / 2;
            } while (numeroEntero != 0);
            return sb.ToString();
        }
        public static double ConvertirBinarioADecimal(double numero)
        {
            string strNumero = numero.ToString();
            int largoCadena = strNumero.Length - 1;
            double acumulador = 0;

            foreach (char item in strNumero)
            {
                if (item == '1')
                {
                    acumulador += Math.Pow(2, largoCadena);
                }
                largoCadena--;
            }
            return acumulador;
        }
        public static double ConvertirBinarioADecimal(string numeroEntero)
        {
            int largoCadena = numeroEntero.Length - 1;
            double acumulador = 0;

            foreach (char item in numeroEntero)
            {
                if (item == '1')
                {
                    acumulador += Math.Pow(2, largoCadena);
                }
                largoCadena--;
            }
            return acumulador;
        }
    }
}
