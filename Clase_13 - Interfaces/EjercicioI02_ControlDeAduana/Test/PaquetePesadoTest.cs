using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{

    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void TienePrioridad_CuandoUnPaqueteEsPesado_DeberiaRetornarFalse()
        {
            PaquetePesado paquete = new PaquetePesado("123", 23, "Lomas", "Avellaneda", 0.5);
            bool actual;

            actual = paquete.TienePrioridad;

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil paquete = new PaqueteFragil("123", 23, "Lomas", "Avellaneda", 0.5);
            decimal expected = 8.05M;
            decimal actual;

            actual = paquete.Impuestos;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicita()
        {
            PaquetePesado paquete = new PaquetePesado("123", 23, "Lomas", "Avellaneda", 0.5);
            decimal expected = 5.75M;
            decimal actual;

            actual = ((IAfip)paquete).Impuestos;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paquete = new PaquetePesado("123", 23, "Lomas", "Avellaneda", 0.5);
            decimal expected = 23 + 8.05M + 5.75M;
            decimal actual;

            actual = paquete.AplicarImpuestos();

            Assert.AreEqual(expected, actual);
        }
    }
}
