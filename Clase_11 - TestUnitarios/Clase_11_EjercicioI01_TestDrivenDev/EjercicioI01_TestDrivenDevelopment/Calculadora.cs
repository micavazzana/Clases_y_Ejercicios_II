using System;

namespace EjercicioI01_TestDrivenDevelopment
{
    public class Calculadora
    {
        /// <summary>
        /// Suma los numeros que recibe de un string
        /// que se encuentran separados por un determinado delimitador
        /// Separa esos numeros, los convierte en enteros y los suma
        /// </summary>
        /// <param name="numeros">cadena de numeros separados por un delimitador elegido</param>
        /// <returns>La suma de los numeros</returns>
        /// <exception cref="NegativoNoPermitidoException"></exception>
        public static int Add(string numeros)
        {
            if (String.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            if (numeros[0] == '/' && numeros[1] == '/')
            {
                char delimitador = numeros[2];
                numeros = numeros.Substring(2).Replace(delimitador, ',');
            }

            string[] arrayStringNumeros = numeros.Split(new char[] { ',', '\n' },StringSplitOptions.RemoveEmptyEntries);
            int acumulador = 0;

            for (int i = 0; i < arrayStringNumeros.Length; i++)
            {
                if(int.Parse(arrayStringNumeros[i]) < 0)
                {
                    throw new NegativoNoPermitidoException($"Numero Negativo: {arrayStringNumeros[i]}");
                }
                acumulador += int.Parse(arrayStringNumeros[i]);
            }
            return acumulador;
        }
    }
}
