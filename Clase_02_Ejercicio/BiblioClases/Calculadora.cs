using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClases
{
    //Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
    //Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
    //Este método devolverá true si el operando es distinto de cero.
    public class Calculadora
    {
        public static int Calcular(int operando1, int operando2, char operacion)
        {
            switch(operacion)
            {
                case '+':
                    return operando1 + operando2;
                case '-':
                    return operando1 - operando2;
                case '*':
                    return operando1 * operando2;
                case '/':
                    if(Calculadora.Validar(operando2))
                    {
                        return operando1 / operando2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                        return 0;
                    }
                default:
                    return 0;
            }
        }

        private static bool Validar(int operando2)
        {
            return operando2 != 0;
        }
    }
}
