using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DateTimeExtendido
    {
        public static double CalcularDiferenciaSegundos(this DateTime fin, DateTime inicio)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
