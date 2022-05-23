using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T>
    {
        T Leer(string ruta);

        bool Escribir(string ruta, T dato, bool append);
    }
}
