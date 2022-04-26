using System;
using System.Text;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public PrestamoPesos(float monto, DateTime vencimiento, float porcentajeInteres)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
            : this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {
        }
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        private float CalcularInteres()
        {
            return base.Monto * this.porcentajeInteres;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            DateTime fechaVencimiento = base.Vencimiento;
            TimeSpan intervalo = DateTime.Now - fechaVencimiento;
            float calculo = (0.25f * base.Monto) / 100;
            base.monto += intervalo.Days * calculo;
            base.Vencimiento = nuevoVencimiento;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Porcentaje de interes: {this.porcentajeInteres}");
            sb.AppendLine($"Interes: ${this.Interes}");
            return sb.ToString();
        }

    }
}
