using System;
using BiblioClases;

namespace Ejercicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I03 - Conversor binario";
            int numero;
            string binario;
            int _decimal;

            if (Inputs.GetNumero("Ingrese el numero que desea convertir a binario", "Error, no ha ingresado un numero valido", int.MinValue, int.MaxValue, out numero))
            { 
                binario = Conversor.ConvertirDecimalABinario(numero);
                Console.WriteLine($"El numero en binario es: {binario}");
            }
            if (Inputs.GetNumero("Ingrese el numero que desea convertir a decimal", "Error, no ha ingresado un numero valido", 0, 1, out numero))
            {
                _decimal = Conversor.ConvertirBinarioADecimal(numero);
                Console.WriteLine($"El numero en decimal es: {_decimal}");
            }
            Console.WriteLine("Vuelva prontos");
            Console.ReadKey();
        }
    }
}
