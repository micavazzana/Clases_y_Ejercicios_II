using System.Collections.Generic;
using System.Text;

namespace Centralita
{
    public class _Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public _Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public _Centralita(string nombreEmpresa)
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
                return this.listaDeLlamadas;//VER
            }

        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;
            foreach (Llamada llamada in Llamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local && llamada is Local)
                {
                    acumulador += ((Local)llamada).CostoLlamada;
                }
                else if (tipo == Llamada.TipoLlamada.Provincial && llamada is Provincial)
                {
                    acumulador += ((Provincial)llamada).CostoLlamada;
                }
                else
                {
                    acumulador += ((Provincial)llamada).CostoLlamada;
                    acumulador += ((Local)llamada).CostoLlamada;
                }
            }
            return acumulador;
        }

        public string Mostrar()
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

        public void OrdenarLlamadas()
        {
           // Llamadas.Sort(OrdenarPorDuracion());
        }
    }
}
