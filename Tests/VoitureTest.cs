using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using agile_herma;



namespace Tests
{
    [TestClass]
    public class VoitureTest
    {

        #region TestsInitiaux
        #region Position

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

        [TestMethod]
        public void TestPositionMax()
        {
            Voiture v = new Voiture(9000, 9000);
            Assert.AreNotEqual(9000, v.Y);
            Assert.AreNotEqual(9000, v.X);
        }

        [TestMethod]
        public void TestCorrectionPositionMaxX()
        {
            Voiture v = new Voiture(10000000, 0);
            Assert.AreEqual(50, v.X);
            Assert.AreEqual(0, v.Y);
        }

        [TestMethod]
        public void TestCorrectionPositionMaxY()
        {
            Voiture v = new Voiture(10000000, 0);
            Assert.AreEqual(50, v.X);
            Assert.AreEqual(0, v.Y);
        }

        [TestMethod]
        public void TestCorrectionPositionMinX()
        {
            Voiture v = new Voiture(-1, 0);
            Assert.AreEqual(0, v.X);
            Assert.AreEqual(0, v.Y);
        }

        [TestMethod]
        public void TestCorrectionPositionMinY()
        {
            Voiture v = new Voiture(0, -1);
            Assert.AreEqual(0, v.X);
            Assert.AreEqual(0, v.Y);
        }

        #endregion


        [TestMethod]
        public void TestDirectionInitiale()
        {
            var v = new Voiture();
            Assert.AreEqual(0, v.Direction);
        }

        [TestMethod]
        public void TestVitesseInitiale()
        {
            var v = new Voiture();
            Assert.AreEqual(0, v.Vitesse);
        }

        #endregion
    }

}
