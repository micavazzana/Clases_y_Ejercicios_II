using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Centralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        private Franja franjaHoraria;


        /* public Provincial(Franja miFranja, Llamada llamada) 
             : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
         {
             this.franjaHoraria = miFranja;
         }
         public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino)
             : this(miFranja, new Llamada(duracion, nroDestino, nroOrigen))
         {
         }*/
        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
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
            sb.AppendLine($"Franja: {this.franjaHoraria}");
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float costo;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                costo = base.Duracion * (float)0.99;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                costo = base.Duracion * (float)1.25;
            }
            else
            {
                costo = base.Duracion * (float)0.66;
            }
            return costo;
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
