using System;

namespace Entidades
{
    public class Delegados
    {
        public delegate void DelegadoSaludar(string str);
        public delegate void DelegadoInformador(string numero);

        //EJEMPLO 1        
        public static void Saludar(string texto)
        {
            Console.WriteLine($"Saludando: '{texto}'");
        }

        //EJEMPLO 2
        public static void Multiplicador(int numero, DelegadoInformador accion)
        {
            if (numero < 0)
            {
                accion("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
        }
        public static void Mensajeador(string mensaje)
        {
            Console.WriteLine(mensaje);
        }


        //EJEMPLO FUNC - ACTION - PREDICATE - COMPARISON
        public static int MetodoQueDevuelveUnEntero()
        {
            return 5;
        }
        public static void MetodoConParametros(int numero)
        {
            Console.WriteLine($"Action que recibe un numero: {numero}");
        }
        public static void MetodoSinParametros()
        {
            Console.WriteLine("Action que no recibe nada");
        }
        public static void MetodoVariosParametros(string a, string b, string c)
        {
            Console.WriteLine("Action varios parametros string: " + a + " " + b + " " + c);
        }
        public static bool MetodoParaPredicate(int a)
        {
            return a > 0;
        }
        public static int MetodoParaComparison(int a, int b)
        {
            if(a > b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public static int MetodoParaComparison(char a, char b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //ENCAPSULAR VARIOS METODOS EN UN DELEGADO
        public static void Saludador1(string texto)
        {
            Console.WriteLine($"Hola {texto}");
        }
        public static void Saludador2(string texto)
        {
            Console.WriteLine($"Como estas {texto}");
        }
        public static void Saludador3(string texto)
        {
            Console.WriteLine($"Chau {texto}");
        }
    }
}
