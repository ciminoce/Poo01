using Ejercicio01.Entidades;

namespace Poo01.Test
{
    [TestClass]
    public sealed class CalculadoraTest
    {
        [TestMethod]
        public void PruebaMetodoSumaOK()
        {
            //arrange
            int numero1 = 2;
            int numero2= 2;
            Calculadora c = new Calculadora(numero1, numero2);
            //act
            var suma=c.Sumar();
            //assert
            Assert.AreEqual(4, suma);
        }
        [TestMethod]
        public void PruebaMetodoRestaOK()
        {
            //arrange
            int numero1 =4;
            int numero2 = 2;
            Calculadora c = new Calculadora(numero1, numero2);

            //act
            var resta = c.Restar();
            //assert
            Assert.AreEqual(2,resta);
        }
        [TestMethod]
        public void PruebaMetodoDivisionOK()
        {
            //arrange
            int numero1 = 5;
            int numero2 = 2;
            Calculadora c = new Calculadora(numero1, numero2);
            //Act
            var division = c.Dividir();
            //Assert
            Assert.AreEqual(2.5,division);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PruebaMetodoDivisionExcepcion()
        {
            //arrange
            int numero1 = 5;
            int numero2 = 0;
            Calculadora c = new Calculadora(numero1, numero2);
            //Act
            var division = c.Dividir();

        }
        [TestMethod]
        public void PruebaMetodoMultiplicacionOK()
        {
            //arrange
            int numero1 = 5;
            int numero2 = 2;
            Calculadora c = new Calculadora(numero1, numero2);
            //Act
            var producto = c.Multiplicar();
            //Assert
            Assert.AreEqual(10, producto);

        }
    }
}
