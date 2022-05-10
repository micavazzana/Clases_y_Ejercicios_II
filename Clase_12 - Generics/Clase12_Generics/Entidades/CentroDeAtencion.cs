using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentroDeAtencion<T> //se puede restringir: where T : Persona //Solo va a admitir Personas
                                     //public class CentroDeAtencion<T, U > where T : Persona where U: T //o where U: Profesor
    {
        List<T> lista;

        public CentroDeAtencion()
        {
            this.lista = new List<T>();
        }

        public void AgregarALaLista(T elemento)
        {
            lista.Add(elemento);
        }
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (T elemento in this.lista)
            {
                stringBuilder.AppendLine(elemento.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
