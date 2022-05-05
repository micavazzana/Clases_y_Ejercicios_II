using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
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
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()
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
        public List<VehiculoDeCarrera> ListaCompetidores
        {
            get 
            { 
                return this.competidores; 
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
                if (vehiculo is AutoF1)
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                else if (vehiculo is MotoCross)
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Añade un vehiculo a la competencia si vehiculo todavia no forma parte de la misma
        /// y si hay espacio para añadirlo
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        /// <exception cref="CompetenciaNoDisponibleException"></exception>
        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            Random r = new Random();
            try
            {
                if (competencia.competidores.Count < competencia.cantidadCompetidores
                        && competencia != vehiculo)
                {
                    competencia.competidores.Add(vehiculo);
                    vehiculo.EsCompetencia = true;
                    vehiculo.VueltasRestantes = competencia.cantidadVueltas;
                    vehiculo.CantidadCombustible = (short)r.Next(15, 100);
                    return true;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +", ex);
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
        /// <summary>
        /// Compara si un vehiculo es de un determinado tipo y esa competencia es de ese tipo
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        /// <exception cref="CompetenciaNoDisponibleException"></exception>
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (vehiculo is MotoCross && competencia.Tipo is TipoCompetencia.MotoCross
                || vehiculo is AutoF1 && competencia.Tipo is TipoCompetencia.F1)
            {
                foreach (VehiculoDeCarrera v in competencia.competidores)
                {
                    if (v == vehiculo)
                    {
                        return true;
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Sobrecarga ==");
            }
            return false;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }
    }
}
