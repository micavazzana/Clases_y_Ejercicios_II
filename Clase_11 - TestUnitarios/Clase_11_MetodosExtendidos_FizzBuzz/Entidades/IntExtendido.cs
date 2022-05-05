using System;
using System.Text;

namespace Entidades
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this Int32 numero)
        {
            StringBuilder sb = new StringBuilder();
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                sb.Append("FizzBuzz");
            }
            else if (numero % 3 == 0)
            {
                sb.Append("Fizz");
            }
            else if (numero % 5 == 0)
            {
                sb.Append("Buzz");
            }
            else
            {
                sb.Append(numero.ToString());
            }
            return sb.ToString();
        }
    }
}
