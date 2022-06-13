using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            // Punto 2
            Comparar(primerTexto, segundoTexto, (str1, str2) => str1.Length - str2.Length);

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            // Punto 3
            Comparar(primerTexto, segundoTexto, (str1, str2) =>
            {
                string[] cadenaRecibida1 = str1.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                int largoCadena1 = cadenaRecibida1.Length;

                string[] cadenaRecibida2 = str2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int largoCadena2 = cadenaRecibida2.Length;

                return largoCadena1 - largoCadena2;
            });

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            // Punto 4
            Comparar(primerTexto, segundoTexto, (str1, str2) => ContarVocales(str1) - ContarVocales(str2));
            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            Comparar(primerTexto, segundoTexto, (str1, str2) => ContarSignosPuntuacion(str1) - ContarSignosPuntuacion(str2));
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }
            return cantidadCaracteres;
        }

        public static void Comparar(string str1, string str2, DelegadoComparacion criterio)
        {
            int retorno = criterio(str1, str2);
            if(retorno == 0)
            {
                Console.WriteLine("Son iguales");
            }
            else if(retorno > 0)
            {
                Console.WriteLine("El primero es mayor al segundo");
            }
            else
            {
                Console.WriteLine("El segundo es mayor al primero");
            }
        }
    }
}
