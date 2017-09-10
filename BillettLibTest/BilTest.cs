using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;

namespace BillettLibTest
{
    [TestClass()]
    public class BilTest
    {

        /*Test om køretøj methoden i bil classen retunerer det den skal*/
        [TestMethod]
        public void TestKøretøj()
        {
            var bil = new Bil();

            Assert.AreEqual("Bil", bil.køretøj());
        }

        /*Test om Pris methoden i bil classen retunerer det den skal*/
        [TestMethod]
        public void TestPris()
        {
            var bil = new Bil();

            Assert.AreEqual(240, bil.Pris());
        }


    }
}
