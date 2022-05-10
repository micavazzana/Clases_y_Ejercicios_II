﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre { get { return this.nombre; } }
        public DateTime FechaCreacion { get { return this.fechaCreacion; } }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Nombre == e2.Nombre && e1.FechaCreacion == e2.FechaCreacion;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            return $"{this.Nombre} fundado el {this.FechaCreacion.ToShortDateString()}";
        }
    }
}
