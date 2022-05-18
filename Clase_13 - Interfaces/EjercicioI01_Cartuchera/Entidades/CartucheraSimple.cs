using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraSimple
    {
        List<Boligrafo> boligrafoList;
        List<Lapiz> lapizList;

        public CartucheraSimple()
        {
            this.boligrafoList = new List<Boligrafo>();
            this.lapizList = new List<Lapiz>();
        }
        public void AniadirBoli(Boligrafo a)
        {
            this.boligrafoList.Add(a);
        }
        public void AniadirLapiz(Lapiz a)
        {
            this.lapizList.Add(a);
        }
        public bool RecorrerElementos()
        {
            bool retorno = false;

            foreach (IAcciones item in boligrafoList)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    retorno = true;
                }
                else
                {
                    item.Recargar(20);
                    retorno = false;
                }
            }
            foreach (IAcciones item in lapizList)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.Escribir("*");
                    retorno = true;
                }
                else
                {
                    item.Recargar(20);
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
