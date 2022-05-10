using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Contabilidad<T, U> 
        where T : Documento 
        where U : Documento, new()
    {
        public List<T> egresos;
        public List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, T egreso)
        {
            contabilidad.egresos.Add(egreso);
            return contabilidad;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            contabilidad.ingresos.Add(ingreso);
            return contabilidad;
        }

    }
}
