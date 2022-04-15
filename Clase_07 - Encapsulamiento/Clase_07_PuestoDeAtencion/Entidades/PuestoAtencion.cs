using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }

        private static int numeroActual;
        private Puesto puesto;
        public static int NumeroActual 
        { 
            get
            {
                //PuestoAtencion.numeroActual++;
                return ++PuestoAtencion.numeroActual;//Agregar el ++ al principio incrementa antes de devolver
            }        
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            if(cli is not null)
            {
                Thread.Sleep(5000);
                return true;
            }
            return false;             
        }
    }
}
