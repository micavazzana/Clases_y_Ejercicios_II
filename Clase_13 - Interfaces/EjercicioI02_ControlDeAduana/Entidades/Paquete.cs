using System;
using System.Text;

namespace Entidades
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }
        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return (this.costoEnvio * 35) / 100;
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envío: ${this.costoEnvio}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Peso: {this.pesoKg}kg");
            if (TienePrioridad)
                sb.AppendLine("Este paquete tiene prioridad");
            else
                sb.AppendLine("Este paquete no tiene prioridad");
            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.Impuestos + this.costoEnvio;
        }
    }
}
