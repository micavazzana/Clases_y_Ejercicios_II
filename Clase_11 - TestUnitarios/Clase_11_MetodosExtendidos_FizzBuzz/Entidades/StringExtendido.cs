using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this String str)
        {
            if(string.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }
            return str.Split(new char[] {' ','-'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
