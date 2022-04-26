using System;
using System.Text;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual, Bimestral, Trimestral
    }
    public enum TipoDePrestamo
    {
        Pesos, Dolares, Todos
    }
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (value > DateTime.Now)
                    this.vencimiento = value;
            }
        }
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return p1.Vencimiento.CompareTo(p2.Vencimiento);
        }
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Monto: ${this.monto}");
            sb.AppendLine($"Fecha de Vencimiento: {this.Vencimiento.ToShortDateString()}");
            return sb.ToString();
        }
    }
}
