using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using agile_herma;



namespace Tests
{
    [TestClass]
    public class VoitureTest
    {
        [TestMethod]
        public void TestPositionDefault()
        {
            Voiture v = new Voiture();
            Assert.AreEqual(0, v.X);
            Assert.AreEqual(0, v.Y);
        }

        public void TestPositionInitiale()
        {
            Voiture v = new Voiture(12, 42);
            Assert.AreEqual(12, v.X);
            Assert.AreEqual(42, v.Y);
        }
    }
}
