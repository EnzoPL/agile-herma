using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using agile_herma;



namespace Tests
{
    [TestClass]
    public class VoitureTest
    {
        [TestMethod]
        public void TestPositionInitiale()
        {
            Voiture v = new Voiture();
            Assert.AreEqual(0, v.X);
            Assert.AreEqual(0, v.Y);

            v = new Voiture(12, 42);
            Assert.AreEqual(12, v.X);
            Assert.AreEqual(42, v.Y);
        }
        /*
        [TestMethod]
        public void TestDirectionInitiale()
        {
            var v = new Voiture();
            Assert.AreEqual(0, v.direction());
        }
        */
        [TestMethod]
        public void TestPosition()
        {
            Voiture v = new Voiture(9000,9000);
            Assert.AreNotEqual(9000, v.Y);
            Assert.AreNotEqual(9000, v.X);
        }


    }

}
