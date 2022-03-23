using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClases
{
    public class Inputs
    {
        public static bool GetNumero(string mensaje, string msjError, int min, int max, out int num)
        {
            int numeroAux;
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numeroAux) && Validador.Validar(numeroAux, min, max))
            {
                num = numeroAux;
                return true;                
            }
            else
            {
                Console.WriteLine(msjError);
            }
            num = numeroAux; //no estoy segura de como resolver esto y no asignar el numero en caso de que este errado el ingreso.
            return false;
        }
    }
}
