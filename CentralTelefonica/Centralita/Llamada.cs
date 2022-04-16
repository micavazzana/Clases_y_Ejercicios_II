using System;
using System.Text;

namespace Centralita
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        { 
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
           return (int)llamada1.Duracion - (int)llamada2.Duracion;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Numero Origen: {this.NroOrigen}");
            sb.AppendLine($"Numero Destino: {this.NroDestino}");
            return sb.ToString();
        }
    }
}
