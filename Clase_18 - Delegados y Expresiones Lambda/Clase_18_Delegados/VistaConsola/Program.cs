using Entidades;
using System;

namespace VistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**************** DELEGADOS *****************\n");
            //Son como un puntero a funcion. Contienen la referencia a metodos
            //En si mismos son de tipo de referencia, podemos asociar la instancia de un delegado
            //a cualquier metodo que tenga una firma compatible.

            //Usando el metodo
            Delegados.Saludar("Hola desde el metodo");
            //Usando la instancia del delegado 
            Delegados.DelegadoSaludar saludador = new Delegados.DelegadoSaludar(Delegados.Saludar);
            saludador("Hola desde el delegado");

            //Usando la instancia del delegado: otra manera
            Delegados.DelegadoSaludar saludador2 = Delegados.Saludar; //Asigno el metodo
            saludador2.Invoke("De nuevo saludando desde el delgado");
            //el invoke va a servir cuando use eventos. Invoca al delegado?

            //Pasando el metodo por parametro
            Delegados.Multiplicador(-5, Delegados.Mensajeador);

            //Existen delegados genericos en la base class library:
            // FUNC - ACTION - PREDICATE
            Console.WriteLine("\n*********** FUNC - ACTION - PREDICATE - COMPARISON *************\n");

            //Usamos FUNC para asignar metodos q retornan algo y reciben o no varios parametros
            //entre los picos <> determino el tipo de lo que devuelve
            Func<int> func = Delegados.MetodoQueDevuelveUnEntero;
            int valorRecibido = func();
            Console.WriteLine($"Valor recibido por FUNC: {valorRecibido}");

            //Usamos ACTION con metodos que no devuelven nada, pueden o no recibir parametros
            Action action = Delegados.MetodoSinParametros;
            action();
            //entre los picos <> determino el tipo de lo que le paso como parametro
            Action<int> action2 = Delegados.MetodoConParametros;
            action2(5);
            //metodo que recube varios parametros
            Action<string, string, string> action3 = Delegados.MetodoVariosParametros;
            action3("texto1", "texto2", "texto3");

            //Usamos PREDICATE, retorna booleano y recibe un solo parametro}
            Predicate<int> predicate = Delegados.MetodoParaPredicate;
            if (predicate(5))
            {
                Console.WriteLine("Predicate retorna true si el numero del parametro es mayor a 0");
            }

            //COMPARISON, compara dos objetos del mismo tipo,
            //entre corchetes el tipo de lo q va a recibir
            Comparison<int> comparison = Delegados.MetodoParaComparison;
            Console.WriteLine($"COMPARISON devuelve 1, 0 o -1: Si 8 es mayor a 4: {comparison(8, 4)}");
            Comparison<char> comparison2 = Delegados.MetodoParaComparison;
            Console.WriteLine($"Si A es Mayor a B: {comparison2('A', 'B')}");

            //Puedo encapsular varios metodos en un delagado, se llama: multidifusion
            Console.WriteLine("\n\n************* ENCAPSULAR VARIOS METODOS: MULTICAST ***************\n");
            Delegados.DelegadoSaludar otroSaludador;
            otroSaludador = Delegados.Saludador1;
            otroSaludador += Delegados.Saludador2;
            otroSaludador += Delegados.Saludador3;
            otroSaludador("Mica");
        }
    }
}
