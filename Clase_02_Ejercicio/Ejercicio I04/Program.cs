using System;
using BiblioClases;

//Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
//Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
//Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
//Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
//Este método devolverá true si el operando es distinto de cero.
//Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
//El usuario decidirá cuándo finalizar el programa.

namespace Ejercicio_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I04 - La calculadora";
            int numero1;
            int numero2;
            char operador;
            int resultado;

            do
            {
                if (Inputs.GetNumero("Ingrese el primer operando: ", "Error, no ha ingresado un numero", int.MinValue, int.MaxValue, out numero1)
                    && Inputs.GetNumero("Ingrese el segundo operando: ", "Error, no ha ingresado un numero", int.MinValue, int.MaxValue, out numero2))
                {
                    Console.WriteLine("Ingrese la operacion que desee realizar: '+' '-' '*' '/': ");
                    operador = Console.ReadKey().KeyChar;
                    resultado = Calculadora.Calcular(numero1, numero2, operador);
                    Console.WriteLine($"\nEl resultado de la operacion es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Si quiere volver a operar debe volver a intentarlo");
                }
                Console.WriteLine("Desea continuar? S/N: ");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }
}
