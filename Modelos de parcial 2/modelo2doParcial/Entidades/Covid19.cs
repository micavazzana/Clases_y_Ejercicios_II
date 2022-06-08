using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Covid19 : Microrganismo
    {
        public Covid19(string nombre) 
            : base(nombre)
        {
        }

        public override long IndiceDeContagios
        {
            get
            {
                return base.contador = base.contador * 5;
            }
        }
    }
}
