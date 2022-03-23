using System;
using BiblioClases;

namespace Ejercicio_I02
{
    //Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
    //Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
    //El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - ¿Desea continuar?";
            int numero;
            string respuesta;
            int sumador = 0;

            do
            {
                if (Inputs.GetNumero("Ingrese un numero entero: ", "No ha ingresado un numero", int.MinValue, int.MaxValue, out numero))
                {
                    sumador = sumador + numero;
                }
                Console.Write("¿Desea continuar? (S/N): ");
                respuesta = Console.ReadLine();
            }
            while (Validador.ValidarRespuesta(respuesta));
            Console.WriteLine($"La suma de los numeros es: {sumador}");
            Console.ReadKey();
        }
    }
}
