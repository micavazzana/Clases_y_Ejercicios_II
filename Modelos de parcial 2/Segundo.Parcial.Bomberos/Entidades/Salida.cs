using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salida()
        {
            this.fechaInicio = DateTime.Now;
           // this.fechaFin = new DateTime();
        }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public double TiempoTotal 
        { 
            get
            {
                return this.fechaFin.CalcularDiferenciaSegundos(this.fechaInicio);
            }
        }

        public void FinalizarSalida()
        {
            this.fechaFin = DateTime.Now;
        }
    }
}
