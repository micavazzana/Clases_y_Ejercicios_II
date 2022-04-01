using System;
using ConversorBinario;

namespace Ejercicio_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal numeroDecimal = 25; //Conversion implicita
            NumeroBinario numeroBinario = "1101"; //Conversion implicita
            double numDec = (double)numeroDecimal; //Conversion explicita
            string strNumBin = (string)numeroBinario; //Conversion explicita

            Console.WriteLine($"El numero decimal es: {numeroDecimal.Numero} " +
                              $"\nEn binario: {((NumeroBinario)numeroDecimal).Numero}");
           
            Console.WriteLine($"El numero binario es: {numeroBinario.Numero} " +
                              $"\nEn decimal: {((NumeroDecimal)numeroBinario).Numero}");
           
            Console.WriteLine($"La suma de los numeros en binario es: {numeroBinario + numeroDecimal}"+
                              $"\nLa suma de los numeros en decimal es: {numeroDecimal + numeroBinario}"+
                              $"\nLa resta de los numeros en binario es: {numeroBinario - numeroDecimal}"+
                              $"\nLa resta de los numeros en decimal es: {numeroDecimal - numeroBinario}");

            Console.WriteLine($"El numero decimal es igual al binario: {numeroDecimal == numeroBinario}");//false
            Console.WriteLine($"El numero binario no es igual al decimal: {numeroBinario != numeroDecimal}");//true

            Console.WriteLine($"Conversion explicita de double: {numDec}" +
                              $"\nConversion explicita de string: {strNumBin}");
        }
    }
}
