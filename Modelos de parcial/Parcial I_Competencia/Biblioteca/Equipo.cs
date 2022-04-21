using System.Text;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre)
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
        public int PartidosEmpatados
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }
        public int PartidosGanados
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }

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
        public int PartidosPerdidos
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }
        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Nombre == equipoB.Nombre && equipoA.Equals(equipoB);
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        public override bool Equals(object obj)
        {
           /* Equipo equipo = obj as Equipo;
            return equipo is not null && this.Tipo == equipo.Tipo;*/
           return obj is not null && this.GetType() == obj.GetType();
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo: {this.Nombre}");
            return sb.ToString();
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            int equipoADificultad = equipoA.GetDificultad();
            int equipoBDificultad = equipoB.GetDificultad();
            if (equipoA.Equals(equipoB))
            {

                equipoA.PartidosJugados++;
                equipoB.PartidosJugados++;
                if (equipoADificultad > equipoBDificultad)
                {
                    equipoA.partidosGanados++;
                    equipoB.partidosPerdidos++;
                    equipoA.Puntuacion += 3;
                }
                else if (equipoADificultad < equipoBDificultad)
                {
                    equipoB.partidosGanados++;
                    equipoA.partidosPerdidos++;
                    equipoB.Puntuacion += 3;
                }
                else
                {
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                    equipoA.PartidosEmpatados++;
                    equipoB.PartidosEmpatados++;
                }
                return true;
            }
            return false;
        }
        public abstract int GetDificultad();
    }
}
