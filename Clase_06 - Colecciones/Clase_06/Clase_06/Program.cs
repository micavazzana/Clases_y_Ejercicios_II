using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------\n  ARRAY UNIDIMENSIONAL\n-----------------------\n");
            ArrayUnidimensional();
            Console.WriteLine("\n\n-----------------------\n  ARRAY BIDIMENSIONAL\n-----------------------\n");
            ArrayBidimensional();
            Console.WriteLine("\n\n-----------------------\n  LISTA\n-----------------------\n");
            List();
            Console.WriteLine("\n\n-----------------------\n  DICCIONARIO\n-----------------------\n");
            Diccionario();
            Console.WriteLine("\n\n-----------------------\n  COLA/QUEUE\n-----------------------\n");
            Queue();
            Console.WriteLine("\n\n-----------------------\n  PILA/STACK\n-----------------------\n");
            Stack();
            Console.WriteLine("\n\n-----------------------\n  LISTA ORDENADA\n-----------------------\n");
            SortedList();
        }

        static void ArrayBidimensional()
        {
            string[,] personas = new string[3, 2];

            personas[0, 0] = "Don Gato";
            personas[0, 1] = "34232111";
            personas[1, 0] = "Benito";
            personas[1, 1] = "34252686";
            personas[2, 0] = "Matute";
            personas[2, 1] = "34345456";

            for (int i = 0; i < personas.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre: {personas[i, 0]} DNI: {personas[i, 1]}");
            }
        }
        static void ArrayUnidimensional()
        {
            string[] nombres = new string[4];

            nombres[0] = "Don Gato";
            nombres[1] = "Benito";

            int [] edades = { 31, 22, 13 };
            Console.WriteLine($"Longitud de nombres: {nombres.Length}");
            Console.WriteLine("Recorro con un for y muestro:");
            for (int i = 0; i < nombres.Length; i++)
            {
                if(nombres[i] is not null)//es lo mismo que decir nombres != null*
                {
                    Console.WriteLine(nombres[i]);
                }
            }
            //*Utilizamos el operador "is" porque el == o != pueden estar sobrecargados
            Console.WriteLine("--------------------------\nRecorro con foreach y muestro: ");
            foreach (string nombre in nombres)
            {
                if(nombre is not null)
                    Console.WriteLine(nombre);
            }
            Console.WriteLine("--------------------------");
            int indice = Array.IndexOf(nombres, "Benito");//Me devuelve el indice de un elemento
            Console.WriteLine($"El indice de Benito es: {indice}");
            //se puede redimensionar el array:
            Array.Resize(ref nombres, 10);
            nombres[6] = "Matute";
            Console.WriteLine("--------------------------\nMuestro array luego de redimensionar y asignar un valor:");
            foreach (string nombre in nombres)
            {
                if(nombre is not null)
                    Console.WriteLine(nombre);
            }
        }
        static void List()
        {
            List<string> listaDeNombres = new List<string>();//Asi declaro una nueva lista

            listaDeNombres.Add("Don Gato");
            listaDeNombres [0] = "Benito";//Piso a Don Gato
            listaDeNombres.Add("Matute");

            Console.WriteLine($"Tamaño de la lista {listaDeNombres.Count}");

            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
            //El insert pone en un determinado indice el valor (como se hizo con Benito)
            //pero corre lo que tiene guardado a un indice mas
            listaDeNombres.Insert(0, "Don Gato");
            Console.WriteLine("-----------------------\nLuego de modificar la lista:");
            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine($"Tamaño de la lista {listaDeNombres.Count}");
            //El Remove, elimina:
            listaDeNombres.Remove("Matute");
            Console.WriteLine("-----------------------\nLuego de borrar un elemento de la lista:");
            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
            //Indexof hace lo mismo que antes
            Console.WriteLine($"El indice de Don gato es: {listaDeNombres.IndexOf("Don Gato")}");
            //Tambien existe el Remove At, que remueve lo que esta en un indice
            listaDeNombres.RemoveAt(0);//Remuevo a Don Gato
            Console.WriteLine("-----------------------\nLuego de borrar otro elemento de la lista:");
            foreach (string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
        }
        static void Diccionario()
        {
            Dictionary<string, int> agenda = new Dictionary<string, int>();
            //Se llaman KeyValuePair - El primer tipo que indico es el Key y el segundo el Value

            agenda.Add("Don gato", 1545653125);
            agenda.Add("Benito", 1556565822);
            agenda.Add("Matute", 1545653125);//El Key debe ser unico, el Value puede repetirse

            foreach (KeyValuePair<string,int> item in agenda)
            {
                Console.WriteLine(item);
            }

            //Puedo recorrer solo los KEY:
            Console.WriteLine("-----------------------\nMuestro solo los KEY:");
            foreach (string nombre in agenda.Keys)
            {
                Console.WriteLine(nombre);
            }
            //Puedo recorrer solo los VALUE:
            Console.WriteLine("-----------------------\nMuestro solo los VALUE:");
            foreach (int numero in agenda.Values)
            {
                Console.WriteLine(numero);
            }
            
            Console.WriteLine("-----------------------\nValor maximo");
            Console.WriteLine(agenda.Values.Max());//Se fija cual es el valor maximo de los Values
            Console.WriteLine("-----------------------\nPuedo mostrar la lista completa dandole un formato:");
            foreach (KeyValuePair<string, int> item in agenda)
            {
                Console.WriteLine($"El key: {item.Key} - El value: {item.Value}");
            }
            Console.WriteLine("-----------------------\nMuestro buscando con el contains:");
            //El contains se fija si hay algo que este en la lista, devuelve un booleano
            if(agenda.ContainsKey("Benito"))//Busca un Key
                Console.WriteLine("Contiene a Benito");
            if (agenda.ContainsValue(1556565822))//Busca un Value
                Console.WriteLine("Contiene el numero de Benito");
        }
        static void Queue()
        {
            Queue<string> colaDeAtencion = new Queue<string>();
            //En una cola, el primero en entrar es el primero en salir (FIFO - First IN First OUT)
            //Agrega elemento al final:
            colaDeAtencion.Enqueue("Don Gato");
            colaDeAtencion.Enqueue("Benito");
            colaDeAtencion.Enqueue("Matute");

            Console.WriteLine("Cola:");
            foreach (string pandillero in colaDeAtencion)
            {
                Console.WriteLine(pandillero);
            }
            colaDeAtencion.Dequeue();//Elimina un elemento: Don Gato
            Console.WriteLine("--------------------\nCola eliminando uno:");
            foreach (string pandillero in colaDeAtencion)
            {
                Console.WriteLine(pandillero);
            }
            Console.WriteLine("-------------------\nProximo por ser atendido: ");
            Console.WriteLine(colaDeAtencion.Peek());//Muestra al primero que esta en la lista
            Console.WriteLine($"-------------------\nCantidad de clientes en espera: {colaDeAtencion.Count}");//tamaño lista
        }
        static void Stack()
        {
            Stack<char> letras = new Stack<char>();
            //En una pila, el ultimo en entrar es el primero en salir (LIFO - Last IN First OUT)
            letras.Push('H');
            letras.Push('O');
            letras.Push('L');
            letras.Push('A');//Esta es la primera

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }
            Console.WriteLine("---------------\nMuestro la letra que queda primera");
            Console.WriteLine(letras.Peek());
            Console.WriteLine("---------------\nElimino la letra: ");
            Console.WriteLine(letras.Pop());
            Console.WriteLine("---------------\nMuestro las letras que me quedan: ");
            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }
            //Siempre la primera es la ultima que agregue, lo mismo al borrar toma la primera que fue la ultima.
        }
        static void SortedList()
        {
            SortedList<string,string> pandilla = new SortedList<string,string>();
            pandilla.Add("Don Gato", "Bigotes");
            pandilla.Add("Benito", "Bigotes");
            pandilla.Add("Matute", "EL Bigote");

            foreach (KeyValuePair<string,string> gato in pandilla)
            {
                Console.WriteLine($"Gato: {gato.Key} - Alias: {gato.Value}");
                //Se muestra ordenada Alfabeticamente por el primer elemnto(KEY)
            }
        }
    }
}
