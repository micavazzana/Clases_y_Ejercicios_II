using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadDeJugadores, string nombre) 
            : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {                
                for (int i = 0; i < e.jugadores.Count; i++)
                {
                    if (j == e.jugadores[i])
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
