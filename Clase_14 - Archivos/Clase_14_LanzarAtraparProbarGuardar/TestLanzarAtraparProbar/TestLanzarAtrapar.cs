using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestLanzarAtraparProbar
{
    [TestClass]
    public class TestLanzarAtrapar
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiMetodoEstatico_CuandoSeQuiereDividirPorCero_DeberiaDevolverDivideByZeroException()
        {
            MiClase.MiMetodoEstatico();
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClaseConstructor_CuandoSeQuiereRelanzarLaExcepcionDeMiMetodoEstatico_DeberiaDevolverDivideByZeroException()
        {
            new MiClase();
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseConstructorConParametro_CuandoSeQuiereLanzarLaExcepcionDeMiClase_DeberiaDevolverUnaExcepcion()
        {
            new MiClase(2);
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void MetodoOtraClase_CuandoSeQuiereLanzarLaExcepcionDeMiClaseConParametro_DeberiaDevolverMiExcepcion()
        {
            OtraClase objeto = new OtraClase();
            objeto.MetodoOtraClase();
        }
    }
}
