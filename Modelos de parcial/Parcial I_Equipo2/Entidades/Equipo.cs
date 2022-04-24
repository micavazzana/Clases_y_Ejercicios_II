using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico dt;
        private List<Jugador> listadoJugadores;
        private string nombre;
        private Equipo()
        {
            this.listadoJugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                    this.dt = value;
            }
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipo: {e.Nombre}");
            if (e.dt is null)
                sb.AppendLine($"Sin DT asignado");
            else
                sb.AppendLine($"Dt: {e.dt.Mostrar()}");
            sb.AppendLine("\nJugadores:");          
            foreach (Jugador jugador in e.listadoJugadores)
            {
                sb.Append(jugador.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.listadoJugadores)
            {
                if (jugador == j)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.listadoJugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.listadoJugadores.Add(j);
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            int contadorArqueros = 0;
            int contadorDefensores = 0;
            int contadorDelanteros = 0;
            int contadorCentral = 0;
            foreach (Jugador jugador in e.listadoJugadores)
            {
                if (jugador.Posicion == Jugador.EPosicion.Arquero)
                    contadorArqueros++;
                if (jugador.Posicion == Jugador.EPosicion.Defensor)
                    contadorDefensores++;
                if (jugador.Posicion == Jugador.EPosicion.Delantero)
                    contadorDelanteros++;
                if (jugador.Posicion == Jugador.EPosicion.Central)
                    contadorCentral++;
            }
            if (e.dt is not null && e.listadoJugadores.Count == cantidadMaximaJugadores && contadorArqueros == 1
                && contadorDefensores >= 1 && contadorDelanteros >=1 && contadorCentral>= 1)
            {
                return true;
            }
            return false;
        }
    }
}
