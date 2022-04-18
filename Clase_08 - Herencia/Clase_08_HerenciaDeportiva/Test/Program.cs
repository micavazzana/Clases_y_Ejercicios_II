using System;
using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "Los pikachu");
            Jugador j1 = new Jugador(232, "Chicorita", 5, 2);
            Jugador j2 = new Jugador(232, "Chicorita", 5, 2);
            Jugador j3 = new Jugador(323, "Bulbasaur", 7, 5);
            Jugador j4 = new Jugador(555, "Charmander", 3, 10);
            Jugador j5 = new Jugador(555, "Squartle", 3, 10);
            DirectorTecnico dt1 = new DirectorTecnico("Profesor Oak", new DateTime(1978,5,25));
            DirectorTecnico dt2 = new DirectorTecnico("Profesor Oak", DateTime.Parse("1989 / 09 / 15"));
           
            dt1.Dni = 3213;
            dt2.Dni = 3212;
            Console.WriteLine($"Director Tecnico 1: \n{dt1.MostrarDatos()}");
            Console.WriteLine($"Director Tecnico 2: \n{dt2.MostrarDatos()}");
            
            if (dt1 == dt2)
            {
                Console.WriteLine("Son el mismo DT\n-----\n");
            }
            else
            {
                Console.WriteLine("Son distintos DT\n-----\n");
            }

            if (equipo + j1)
            {
                Console.WriteLine($"Jugador 1: \n{j1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO JUGADOR 1:  {j1.Nombre} ****\n");
            }

            if (equipo + j2)
            {
                Console.WriteLine($"Jugador 2: \n{j2.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO JUGADOR 2: {j2.Nombre} ****\n");
            }

            if (equipo + j3)
            {
                Console.WriteLine($"Jugador 3: \n{j3.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO JUGADOR 3: {j3.Nombre} ****\n");
            }

            if (equipo + j4)
            {
                Console.WriteLine($"Jugador 4: \n{j4.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO JUGADOR 4: {j4.Nombre} ****\n");
            }

            if (equipo + j5)
            {
                Console.WriteLine($"Jugador 5: \n{j5.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO JUGADOR 5: {j5.Nombre} ****\n");
            }
        }
    }
}
