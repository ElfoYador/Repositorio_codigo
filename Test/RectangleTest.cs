using BasicosCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class RectangleTest
    {
        
        [TestMethod]
        [DataRow (1,1,1)] 
        [DataRow(5,4,20)]
        [DataRow(10,15, 150)]
        public void AreaRectangleTest(double ancho,double alto, double area)
        {
            Rectangle miRectangulo = new Rectangle(ancho, alto);
            // miCuadrado.lado = 4;
            double real = miRectangulo.area();
            
            Assert.AreEqual(area, real);

          }

        [TestMethod]
        [DataRow(1, 1, 4)]
        [DataRow(5, 4, 18)]
        [DataRow(10, 15, 50)]
        public void PerimetroRectangleTest(double ancho, double alto, double perimetro)
        {
            Rectangle miRectangulo = new Rectangle(ancho, alto);
            double real = miRectangulo.perimetro();
            Assert.AreEqual(perimetro, real);

          
        }

        [TestMethod]
        [DataRow(-1,2)]
        public void LadoNegativoTest(double ancho,double alto)
        {
            
            Assert.ThrowsException<System.Exception>(()=>new Rectangle(ancho,alto));
                
        }
    }
}
