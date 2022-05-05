using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        /// <summary>
        /// Constructor de MiClase, arroja la excepcion devuelta por el metodo estatico.
        /// Relanza la DivideByZeroException
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public MiClase()
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException("Relanzo DivideByZero", ex);
            }
        }
        /// <summary>
        /// Constructor de MiClase, arroja la excepcion devuelta por el constructor sin parametros.
        /// Arroja una nueva Excepcion: UnaExcepcion
        /// </summary>
        /// <param name="n"></param>
        /// <exception cref="UnaExcepcion"></exception>
        public MiClase(int n)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException exDiv)
            {
                throw new UnaExcepcion("una excepcion",exDiv);
            }
        }

        /// <summary>
        /// Metodo estatico que arroja DivideByZeroException 
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
    }
}
