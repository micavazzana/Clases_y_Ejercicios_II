using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        private float costo;

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {base.Duracion}");
            sb.AppendLine($"Numero Origen: {base.NroOrigen}");
            sb.AppendLine($"Numero Destino: {base.NroDestino}"); // Preguntar: poruqe puedo poner this.?
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
    }
}
