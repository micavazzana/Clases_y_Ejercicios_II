using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;
            foreach (IAduana impuestoAduana in this.impuestosAduana)
            {
                total += impuestoAduana.Impuestos;
            }
            return total;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAfip impuestoAfip in this.impuestosAfip)
            {
                total += impuestoAfip.Impuestos;
            }
            return total;
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach(Paquete paquete in paquetes)
            {
                RegistrarImpuestos(paquete);
            }
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if (paquete is IAfip)
                this.impuestosAfip.Add((IAfip)paquete);
        }

    }
}
