using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;

namespace BillettLibTest
{
    [TestClass]
    public class MCtests
    {
        [TestMethod]
        public void testMcPris()
        {
            var MC = new MC();

            Assert.AreEqual(125, MC.Pris());
        }

        [TestMethod]
        public void testMcKøretøj()
        {
            var MC = new MC();

            Assert.AreEqual("MC", MC.køretøj());
        }
    }
}
