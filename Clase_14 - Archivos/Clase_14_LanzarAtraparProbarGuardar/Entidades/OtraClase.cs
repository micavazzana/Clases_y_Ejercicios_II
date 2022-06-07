using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        /// <summary>
        /// Metodo que arroja la excepcion devuelta por el constructor que recibe un numero
        /// (UnaExcepcion). Arroja una nueva exepcion: MiExcepcion
        /// </summary>
        /// <exception cref="MiExcepcion"></exception>
        public void MetodoOtraClase()
        {
            try
            {
                new MiClase(2);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("mi excepcion", ex);
            }
        }
    }
}
