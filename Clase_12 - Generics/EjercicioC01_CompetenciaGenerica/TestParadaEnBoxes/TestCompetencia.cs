using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestParadaEnBoxes
{
    [TestClass]
    public class TestCompetencia
    {
        [TestMethod]
        public void ListaCompetidores_CuandoSeInstanciaUnaCompetencia_DeberiaDevolverUnaListaInstanciada()
        {
            //Arrange
            Competencia<VehiculoDeCarrera> competencia = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);

            //Assert
            Assert.IsNotNull(competencia.ListaCompetidores);
        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Add_CuandoSeQuiereAgregarUnAutoEnUnaCompetenciaDeMoto_DeberiaDevolverCompetenciaNoDisponibleException()
        {
            Competencia<VehiculoDeCarrera> motocross = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(4, "Red Bull Racing", 2);

            bool añadeAuto = motocross + a1;
        }
        [TestMethod]
        public void Add_CuandoSeQuiereAgregarUnaMotoEnUnaCompetenciaDeMoto_DeberiaDevolverTrue()
        {
            Competencia<VehiculoDeCarrera> motocross = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool añadeMoto = motocross + m1;

            Assert.IsTrue(añadeMoto);
        }
        [TestMethod]
        public void Add_CuandoSeQuiereAgregarUnVehiculoEnUnaCompetenciaYVerificarQueSeHayaAniadido_DeberiaDevolverTrue()
        {
            Competencia<VehiculoDeCarrera> motocross = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool añadeMoto = motocross + m1;
            bool existe = motocross == m1;

            Assert.IsTrue(existe);
        }
        [TestMethod]
        public void Add_CuandoSeQuiereQuitarUnVehiculoEnUnaCompetenciaYVerificarQueSeHayaQuitado_DeberiaDevolverTrue()
        {
            Competencia<VehiculoDeCarrera> motocross = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);

            bool añadeMoto = motocross + m1;
            bool quitaMoto = motocross - m1;
            bool existe = motocross != m1;

            Assert.IsTrue(existe);
        }
    }
}
