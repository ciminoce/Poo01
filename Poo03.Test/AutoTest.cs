using Poo03.Entidades;

namespace Poo03.Test
{
    [TestClass]
    public sealed class AutoTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("FORD", "FIESTA", "AZUL", 2015, "IXE 386", 10)]
        [DataRow("FORD", "FIESTA", "AZUL", 2019, "IX 386 AB", 6)]

        public void ConstructorAutoOK(string marca, string modelo, string color, int anioFab, string patente, int antiguedadEsperada)
        {
            //arrange
            Auto auto = new Auto(marca, modelo, color, anioFab, patente);
            //act
            int antiguedadCalculada = auto.Antiguedad();
            //assert
            Assert.AreEqual(antiguedadEsperada, antiguedadCalculada);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("", "FIESTA", "AZUL", 2015, "IXE 386")]
        [DataRow("FORD", "", "AZUL", 2015, "IXE 386")]
        [DataRow("FORD", "FIESTA", "", 2015, "IXE 386")]
        [DataRow("FORD", "FIESTA", "AZUL", 2026, "IXE 386")]
        [DataRow("FORD", "FIESTA", "AZUL", 2026, "IXEX 386")]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorAutoArrojaExcepcion(string marca, string modelo, string color, int anioFab, string patente)
        {
            //arrange
            Auto auto = new Auto(marca, modelo, color, anioFab, patente);
            //act && Assert
            
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("FORD", "FIESTA", "AZUL", 2015, "IXE 386",true)]
        [DataRow("FORD", "FIESTA", "AZUL", 2015, "IX 386 EE",true)]
        public void ValidarPatenteOK(string marca, string modelo, string color, int anioFab, string patente, bool resultadoEsperado)
        {
            Auto auto = new Auto(marca, modelo, color, anioFab, patente);
            bool resultadoCalculado = auto.ValidarPatente(patente);
            Assert.IsTrue(resultadoCalculado);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("FORD", "FIESTA", "AZUL", 2015, "IXEX 386")]
        [DataRow("FORD", "FIESTA", "AZUL", 2015, "IXX 386 EE")]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidarPatenteFalso(string marca, string modelo, string color, int anioFab, string patente)
        {
            Auto auto = new Auto(marca, modelo, color, anioFab, patente);

            //Assert.ThrowsException<ArgumentException>(() =>new Auto(marca, modelo, color, anioFab, patente));

        }
        [TestMethod]
        public void ValidarAnioFabricacionOK()
        {
            Auto auto = new Auto("Ford", "Fiesta", "Verde", 2015, "AAA 111");
            int antiguedadEsperada = 10;
            int antiguedadCalculada = auto.Antiguedad();
            Assert.AreEqual(antiguedadEsperada, antiguedadCalculada);
        }
    }
}
