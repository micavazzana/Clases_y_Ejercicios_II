using System;
using System.Text;
using System.Collections.Generic;

namespace Biblioteca
{
    public enum SistemaOperativo
    {
        ANDROID, IOS
    }
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }
        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }
        protected abstract int Tamanio { get; }
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre.ToString()}");
            sb.AppendLine($"Sistema operativo: {this.SistemaOperativo}");
            sb.AppendLine($"Tamaño: {this.Tamanio}mb");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int max = int.MinValue;
            Aplicacion appAux = null;
            foreach (Aplicacion aplicacion in listaApp)
            {
                if (aplicacion.Tamanio > max)
                {
                    max = aplicacion.Tamanio;
                    appAux = aplicacion;
                }             
            }
            return appAux;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach(Aplicacion aplicacion in listaApp)
            {
                if(aplicacion.nombre == app.nombre)
                    return true;
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }        
    }
}
