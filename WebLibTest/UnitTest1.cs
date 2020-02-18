using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WbLib;

namespace WebLibTest
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void TestSquare()
        {
            Calulator c = new Calulator();
            Assert.AreEqual(100, c.Square(10));
        }
        [TestMethod]
        public void TestCube()
        {
            Calulator c = new Calulator();
            Assert.AreEqual(1000, c.Cube(10));
        }

    }
}
