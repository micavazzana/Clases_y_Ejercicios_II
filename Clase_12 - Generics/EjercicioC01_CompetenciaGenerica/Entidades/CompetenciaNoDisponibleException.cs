﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) 
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) 
            : this(mensaje, clase, metodo,null)
        {
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Message}");
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine($"Algo salio mal");
            sb.AppendLine($"{this.InnerException}\t");
            return sb.ToString();
        }


    }
}
