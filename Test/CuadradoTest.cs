using BasicosCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CuadradoTest
    {
        
        [TestMethod]
        [DataRow (1,1)] 
        [DataRow(5,25)]
        [DataRow(10, 100)]
        public void AreaCuadradoTest(double lado, double area)
        {
            Cuadrado miCuadrado = new Cuadrado(lado);
            // miCuadrado.lado = 4;
            double real = miCuadrado.area();
            
            Assert.AreEqual(area, real);

          }

        [TestMethod]
        public void PerimetroCuadradoTest()
        {
            Cuadrado miCuadrado = new Cuadrado(4);
            // miCuadrado.lado = 4;
            double real = miCuadrado.perimetro();
            double esperado = 16;
            Assert.AreEqual(esperado, real);

            miCuadrado = new Cuadrado(10);
            // miCuadrado.lado = 4;
            real = miCuadrado.perimetro();
            esperado = 40;
            Assert.AreEqual(esperado, real);
        }

        [TestMethod]
        [DataRow(-1)]
        public void LadoNegativoTest(double lado)
        {
            
            Assert.ThrowsException<System.Exception>(()=>new Cuadrado(lado));
                
        }
    }
}
