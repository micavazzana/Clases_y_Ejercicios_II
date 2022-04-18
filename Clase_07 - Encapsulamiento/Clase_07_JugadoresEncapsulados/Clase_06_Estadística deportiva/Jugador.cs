using System;
using System.Text;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre)
            : base(nombre, dni)
        {
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
            : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set 
            {
                this.totalGoles = value; 
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)totalGoles / partidosJugados;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {PartidosJugados}");
            sb.AppendLine($"Total goles: {TotalGoles}");
            sb.AppendLine($"Promedio de goles: {PromedioGoles}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
