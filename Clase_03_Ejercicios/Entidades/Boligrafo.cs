using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private static int Nu(out int n)
        {
            int.TryParse(Console.ReadLine(), out n);
            return 0;
        }
        private static int Nu(int n)
        {
            return n;
        }

    }
}
