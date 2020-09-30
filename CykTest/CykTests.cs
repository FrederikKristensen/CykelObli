using System;
using CykelObli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CykTest
{
    [TestClass]
    public class CykTests
    {
        private CykelClass.Cykel cy1;

        [TestInitialize()]
        public void TestInitializer()
        {
            cy1 = new CykelClass.Cykel(2,"Gul",200,23); 
        }

        [TestMethod]
        public void CykelConstructor()
        {
            Assert.AreEqual(2,cy1.Id);
            Assert.AreEqual("Gul",cy1.Farver);
            Assert.AreEqual(200,cy1.Pris);
            Assert.AreEqual(23,cy1.Gear);
        }

        [TestMethod()]
        public void CykId()
        {
            cy1.Id = 2;
        }

        [TestMethod()]
        public void CykFarver()
        {
            cy1.Farver = "Gul";
        }

        [TestMethod()]
        public void CykPris()
        {
            cy1.Pris = 200;
        }

        [TestMethod()]
        public void CykGear()
        {
            cy1.Gear = 23;
        }
    }
}
