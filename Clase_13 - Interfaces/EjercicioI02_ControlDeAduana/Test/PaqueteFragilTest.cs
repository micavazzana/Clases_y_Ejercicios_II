using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_CuandoUnPaqueteEsFragil_DeberiaRetornarTrue()
        {
            PaqueteFragil paquete = new PaqueteFragil("123",23,"Lomas","Avellaneda",0.5);
            bool actual;

            actual = paquete.TienePrioridad;

            Assert.IsTrue(actual);
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
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil paquete = new PaqueteFragil("123", 23, "Lomas", "Avellaneda", 0.5);
            decimal expected = 23 + 8.05M;
            decimal actual;

            actual = paquete.AplicarImpuestos();

            Assert.AreEqual(expected, actual);
        }

    }
}
