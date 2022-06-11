using System;
using System.Threading;
using System.Threading.Tasks;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONCURRENCIA
            //Cuando se ejecuta mas de una tarea al mismo tiempo
            //Permite la interaccion con la interfaz de manera no bloqueante,
            //se pueden atender varias peticiones en simultaneo

            //HILO -> los encargados de ejecutar el codigo sentencia a sentencia
            //es como el sistema operativo asigna tiempo de procesamiento
            //Un PROCESO es un programa que en ejecucion tiene asignados recursos/Cada proceso tiene un unico hilo

            //MULTIHILO
            //Permite que un proceso se ejecute sobre multiples hilos
            //El hilo principal es el hilo sobre el cual se empieza a ejecutar la app
            //A partir de ese hilo se puede abrir un hilo secundario, el cual va a tener su propia pila de ejecucion

            ////Al poner el metodo en un task lo pongo en un hilo secundario
            Task tarea = new Task(MiMetodoContador);
            tarea.Start();//Al darle start esta ejecutandose como hilo secundario

            Console.WriteLine($"El id de la tarea: {tarea.Id}");
            Console.WriteLine($"Este es mi hilo principal. El id es {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("La tarea contadora se esta ejecutando en paralelo");
            Console.WriteLine($"ESTO es de TASK: {Task.CurrentId}");

            tarea.Wait();//Pauso el hilo principal y espero a q termine el hilo que tengo en la tarea
            Console.WriteLine("Muestro luego de esperar a la tarea");

            ConsoleKey teclaPresionada;

            //Task tarea = new Task(ImprimirHora);
            //tarea.Start();
            //Task.Run(ImprimirHora);
            Task.Run(() => ImprimirHora());//esto si la tarea no la voy a usar en ningun otro lado
            do
            {
                teclaPresionada = Console.ReadKey().Key;
                Console.WriteLine("La tecla presionada es {0}", teclaPresionada);
            } while (teclaPresionada != ConsoleKey.Escape);

            //CANCELAR UN HILO
            CancellationTokenSource cancelacion = new CancellationTokenSource();
            CancellationToken cancelToken = cancelacion.Token;
            Task.Run(() => ImprimirHora(cancelacion), cancelToken);
            //El metodo run, recibe el delegado(metodo y su parametro) y el token

            do
            {
                teclaPresionada = Console.ReadKey().Key;
                Console.WriteLine("La tecla presionada es {0}", teclaPresionada);
                if(teclaPresionada == ConsoleKey.Enter)//Si toco enter, llamo al CANCEL
                    cancelacion.Cancel();
            } while (teclaPresionada != ConsoleKey.Escape);
        }

        static void RepasoDelegadosYLambda()
        {
            //FUNC: metodos que devuelven algo si o si, pueden recibir o no parametros (hasta 16)
            Func<int, int, int> funcSuma = (x, y) => x + y;
            Console.WriteLine(funcSuma(2, 3));

            //ACTION: metodos que no devuelven nada, pueden recibir o no parametros (hasta 16)
            Action<string> ImprimeTexto = texto => Console.WriteLine(texto);
            ImprimeTexto("Hola Mundo");
            Action Imprime = () => Console.WriteLine("sin parametros");
            Imprime();

            //COMPARISON: metodos que se usan para comparar, reciben dos parametros y devuelve un entero
            Comparison<int> comp2 = (num1, num2) => num1 - num2; //Devolvia 0 cuando ambos son iguales
                                                                 //Mayor a 0 cuando el 1ro es mayor al 2do
                                                                 //Menos a 0 cuando el 1ro es menor al 2do

            //PREDICATE: metodos que devuelven un booleano y solo pueden recibir un parametro
            Predicate<int> predicate = num1 => num1 == 1;
            Console.WriteLine(predicate(1));
        }

        static void MiMetodoContador()
        {
            Console.WriteLine($"Este es mi metodo. El id es {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"ESTO es de TASK en el METODO: {Task.CurrentId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero de iteracion: {0}", i);
                Thread.Sleep(1000); //Sleep duerme el hilo, recibe el numero en milisegundos (en enteros)
                                    //Es como una pausa
            }
        }

        static void ImprimirHora()
        {
            do
            {
                Console.Title = $"La hora actual es: {DateTime.Now}";
                Thread.Sleep(1000);
            }
            while (true);
        }

        static void ImprimirHora(CancellationTokenSource cancelacion)
        {
            do
            {
                Console.Title = $"La hora actual es: {DateTime.Now}";
                Thread.Sleep(1000);
            }
            while (!cancelacion.IsCancellationRequested);
        }
    }
}
