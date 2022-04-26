
using System;
using System.Text;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {
        }
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            if (this.periodicidad == PeriodicidadDePagos.Mensual)
            {
                return base.Monto * 25;
            }
            else if (this.periodicidad == PeriodicidadDePagos.Bimestral)
            {
                return base.Monto * 35;
            }
            else
            {
                return base.Monto * 40;
            }
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            DateTime fechaVencimiento = base.Vencimiento;
            TimeSpan intervalo = DateTime.Now - fechaVencimiento;
            base.monto += intervalo.Days * 2.5f;
            base.Vencimiento = nuevoVencimiento;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Periodicidad de pagos: {this.Periodicidad}");
            sb.AppendLine($"Interes: ${this.Interes}");
            return sb.ToString();
        }
    }
}
