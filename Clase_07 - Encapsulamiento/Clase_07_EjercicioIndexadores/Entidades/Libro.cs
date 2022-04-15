using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                //si esta en el rango correcto sino retorna string vacio
                if(i >= 0 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return string.Empty;
            }
            set 
            {
                //Si no existe (si el índice es superior al máximo existente), agregará una nueva página.
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if(i >=0) //valido que sea mayor a 0
                {
                    this.paginas.Insert(i, value);
                }
            }
        }
    }
}
