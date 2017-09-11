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

            Assert.AreEqual("Bil", bil.KøretøjType());
        }

        /*Test om Pris methoden i bil classen retunerer det den skal*/
        [TestMethod]
        public void TestPris()
        {
            var bil = new Bil();

            Assert.AreEqual(240, bil.Pris());
        }


        /*Test om nummerpladen er længere en 7 tegn, vis den er kast en ArgumentException*/
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBilLængdeAfNp()
        {
            var bil = new Bil();
            var t = bil.Nummerplade = "123456789";

            Assert.AreEqual("123456789", t);
        }

    }
}
