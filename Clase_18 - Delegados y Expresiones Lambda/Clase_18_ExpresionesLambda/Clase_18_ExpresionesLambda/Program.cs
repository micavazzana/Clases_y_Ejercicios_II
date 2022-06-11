using System;
using System.Linq;
using System.Collections.Generic;

namespace Clase_18_ExpresionesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Las expresiones lambda se utilizan para resolver en una expresion
            //el desarrollo de un metodo.
            //Se suelen utilizar como argumentos de metodos que tienen delegados como parametros

            Func<int, int> delegadoCalculadorPotencia = CalcularPotenciaAlCuadrado;
            Console.WriteLine($"2 a la potencia: {delegadoCalculadorPotencia(2)}");

            //lo que tengo a la derecha: n es el parametro, lo que prosigue a la flecha es el cuerpo:
            Func<int, int> delegadoCalculadorPotencia2 = n => n * n;
            //Funciona igual que el anterior
            Console.WriteLine($"2 a la potencia: {delegadoCalculadorPotencia2(2)}");

            //Ejemplos de usos:
            Comparison<int> comparison = (num1, num2) => num1 - num2; //Se fija cual es mayor de los dos parametros
            Predicate<int> predicate = num1 => num1 > 18;//true o false si el numero que le paso es mayor o menor a 18

            //Uso de la expresion anterior
            Console.WriteLine($"Resultado de la comparacion entre 12 y 4: {comparison(12, 4)}");
            Console.WriteLine($"Es mayor a 18: {predicate(25)}");

            Action<string> action = mensaje => Console.WriteLine($"Muestro Mensaje: {mensaje}");
            action("Hola mundo");

            Console.WriteLine("\n********* EJEMPLO LISTA ORDENADA *********\nOrdeno por edad:\n");
            //EJEMPLO CON UNA LISTA:
            List<Persona> personas = new List<Persona>() {

                new Persona("Lynch",58),
                new Persona("Tarantino",65),
                new Persona("Spielberg",45),
                new Persona("Spielberg",45)
            };

            Comparison<Persona> comparison2 = (p1, p2) => p1.Edad - p2.Edad;
            personas.Sort(comparison2);
            //personas.Sort((p1,p2) => p1.Edad - p2.Edad);
            //Cualquiera de las dos opciones es lo mismo
            personas.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("\n********** EJEMPLO USANDO LINQ *********\n");
            //Puedo hacer querys, o filtrar
            IEnumerable<Persona> personasMaoyoresA60 = personas.Where(p => p.Edad > 60);
            IEnumerable <Persona> listaSinDuplicados = (from item in personas group item by new { item.Edad} into list select new Persona() {Edad = list.Key.Edad}).ToList();
            Console.WriteLine("Mayores a 60:\n");
            personasMaoyoresA60.ToList().ForEach(p => Console.WriteLine(p.ToString()));
            Console.WriteLine("\nLas edades sin repetir:\n");
            listaSinDuplicados.ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }

        static int CalcularPotenciaAlCuadrado(int num)
        {
            return num * num;
        }
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Persona() { }
            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
            public override string ToString()
            {
                return $"{Nombre} - {Edad}";
            }
        }
    }
}
