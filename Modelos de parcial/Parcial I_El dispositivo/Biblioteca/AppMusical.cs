using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial) 
            :this(nombre, sistemaOperativo,tamanioInicial, new List<string>())
        {
        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> canciones) 
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = canciones;
        }

        protected override int Tamanio
        {
            get
            {
                int i = 0;
                foreach (string cancion in listaCanciones)
                {
                    i += 2;
                }
                return this.tamanioMb + i;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            foreach (string cancion in listaCanciones)
                sb.AppendLine(cancion);
            return sb.ToString();
        }
    }
}
