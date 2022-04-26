using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Marvel
    {
        private static List<Personaje> listaPersonajes;

        static Marvel()
        {
            Marvel.listaPersonajes = new List<Personaje>();
        }
        public static Personaje Personaje
        {
            set
            {
                if(listaPersonajes != value)
                {
                    listaPersonajes.Add(value);
                }
            }
        }
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Personaje personaje in listaPersonajes)
            {
                if(personaje is Avenger)
                {
                    sb.AppendLine("****** AVENGER ******");
                }
                else
                {
                    sb.AppendLine("****** ENEMIGO ******");
                }
                sb.AppendLine(personaje.ToString());
            }
            return sb.ToString();
        }
    }
}
