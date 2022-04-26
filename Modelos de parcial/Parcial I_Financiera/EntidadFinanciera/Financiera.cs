using PrestamosPersonales;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }
        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Pesos); ;
            }
        }
        public float InteresesTotales
        {
            get
            {
                return CalcularInteresGanado(TipoDePrestamo.Todos); ;
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float acumuladorPrestamoPesos = 0;
            float acumuladorPrestamoDolares = 0;
            foreach (Prestamo p in ListaDePrestamos)
            {
                if (p is PrestamoDolar)
                {
                    acumuladorPrestamoDolares += ((PrestamoDolar)p).Interes;
                }
                else
                {
                    acumuladorPrestamoPesos += ((PrestamoPesos)p).Interes;
                }
            }
            switch (tipoPrestamo)
            {
                case TipoDePrestamo.Dolares:
                    return acumuladorPrestamoDolares;
                case TipoDePrestamo.Pesos:
                    return acumuladorPrestamoPesos;
                default:
                    return acumuladorPrestamoDolares + acumuladorPrestamoPesos;
            }

        }
        public void OrdenarPrestamos()
        {
            ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        //sobrecarga operadores
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            sb.AppendLine($"Razon social: {financiera.RazonSocial}");
            sb.AppendLine($"Intereses total ganados: {financiera.InteresesTotales}");
            sb.AppendLine($"Intereses en pesos: {financiera.InteresesEnPesos}");
            sb.AppendLine($"Intereses en dolares: {financiera.InteresesEnDolares}\n");
            foreach (Prestamo p in financiera.ListaDePrestamos)
            {
                ++i;
                sb.AppendLine($"Prestamo {i}");
                sb.AppendLine(p.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach(Prestamo p in financiera.ListaDePrestamos)
            {
                if(p == prestamo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }
        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (financiera != prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
