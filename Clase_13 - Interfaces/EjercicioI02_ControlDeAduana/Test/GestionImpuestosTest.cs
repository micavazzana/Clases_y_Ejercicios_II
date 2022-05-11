using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("123", 100, "Lomas", "Avellaneda", 0.5));//35% Aduana
            paquetes.Add(new PaquetePesado("456", 100, "Lomas", "Avellaneda", 0.5));//35% Aduana
            GestionImpuestos gestion = new GestionImpuestos();
            decimal expected = 70;
            decimal actual;
            
            gestion.RegistrarImpuestos(paquetes);
            actual = gestion.CalcularTotalImpuestosAduana();

            Assert.AreEqual(expected, actual);        
        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("123", 100, "Lomas", "Avellaneda", 0.5));//no me da impuestoAfip
            paquetes.Add(new PaquetePesado("456", 100, "Lomas", "Avellaneda", 0.5));//25% Afip
            GestionImpuestos gestion = new GestionImpuestos();
            decimal expected = 25;
            decimal actual;

            gestion.RegistrarImpuestos(paquetes);
            actual = gestion.CalcularTotalImpuestosAfip();

            Assert.AreEqual(expected, actual);
        }

    }
}
