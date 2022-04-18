using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores, TipoCompetencia tipo)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores 
        { 
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas 
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public TipoCompetencia Tipo
        {
            get 
            { 
                return this.tipo; 
            }
            set 
            { 
                this.tipo = value; 
            }
        }
        
        public VehiculoDeCarrera this[int i]
        {
            get 
            { 
                return this.competidores[i];
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine("Competidores: \n");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                if(vehiculo is AutoF1)
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                else if(vehiculo is MotoCross)
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            Random r = new Random();
            if(competencia.competidores.Count < competencia.cantidadCompetidores && competencia!=vehiculo)
            {
                competencia.competidores.Add(vehiculo);
                vehiculo.EsCompetencia = true;
                vehiculo.VueltasRestantes = competencia.cantidadVueltas;
                vehiculo.CantidadCombustible = (short)r.Next(15, 100);
                return true;
            }          
            return false;
        }
        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (competencia == vehiculo)
            {
                competencia.competidores.Remove(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if(vehiculo is MotoCross && competencia.Tipo is TipoCompetencia.MotoCross 
                || vehiculo is AutoF1 && competencia.Tipo is TipoCompetencia.F1)
            {
                /*foreach (VehiculoDeCarrera v in competencia.competidores)
                {
                    if (v == vehiculo)
                    {
                        return true;
                    }
                }*/
            }
            else
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }
    }
}
