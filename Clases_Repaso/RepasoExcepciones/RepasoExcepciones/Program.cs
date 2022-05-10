using System;

namespace RepasoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayPalabras = new string[4] { "pepe", "pepita", "pepito", null };

            try
            {
                string resultado = DevolverPalabra(arrayPalabras, "juan");
            }
            catch (Exception ex)
            {

            }
            //Console.WriteLine(resultado);

        }

        private static string DevolverPalabra(string[] arrayPalabras, string palabraBuscada)
        {
            for (int i = 0; i < arrayPalabras.Length; i++)
            {
                if(arrayPalabras[i].Trim().ToLower() == palabraBuscada.Trim().ToLower())
                 return arrayPalabras[i];
            }
            return "No esta";
        }
        private static string DevolverPalabraPorIndice(int indice)
        {
           ///
            return "";
        }
    }
}
