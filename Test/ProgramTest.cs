using BasicosCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestFactorialFor()
        {
            int esperado = 6;
            int real = Program.factorialFor(3);
            Assert.AreEqual(real, esperado);
           

        }


        [TestMethod]
        public void TestFactorialCero()
        {
            int esperado = 1;
            int real = Program.factorialFor(0);
            Assert.AreEqual(real, esperado);
            

        }
    }
}
