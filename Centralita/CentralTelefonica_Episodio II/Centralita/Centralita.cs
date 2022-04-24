using System.Collections.Generic;
using System.Text;

namespace _Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }

        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumuladorLocal = 0;
            float acumuladorProvincial = 0;

            foreach (Llamada llamada in Llamadas)
            {
                if(llamada is Local)
                {
                    acumuladorLocal += ((Local)llamada).CostoLlamada;
                }
                else
                {
                    acumuladorProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }
            if (tipo == Llamada.TipoLlamada.Local)
                return acumuladorLocal;
            else if (tipo == Llamada.TipoLlamada.Provincial)
                return acumuladorProvincial;
            else
                return acumuladorLocal + acumuladorProvincial;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razón social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {GananciasPorTotal}");
            sb.AppendLine($"Ganancias por llamados locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamados provinciales: {GananciasPorProvincial}");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
           Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
                Llamadas.Add(nuevaLlamada);
        }

        public static bool operator == (Centralita central, Llamada llamada)
        {
            foreach (Llamada item in central.Llamadas)
            {
                if(item == llamada)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Centralita central, Llamada llamada)
        {
            return !(central == llamada);
        }

        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if(central != llamada)
            {
                central.AgregarLlamada(llamada);
            }
            return central;
        }
    }
}
