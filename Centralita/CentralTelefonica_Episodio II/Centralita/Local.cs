using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Centralita
{
    public class Local : Llamada
    {
        private float costo;

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
