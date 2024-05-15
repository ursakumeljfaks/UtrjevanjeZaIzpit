using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestZaRegistracijo
{
    [TestClass]
    public class TestZaRegistracijo
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ni ustrezna registracija, ker ni sestavljena iz 5. znakov!")]
        public void TestMethod1()
        {
            Registracija.Registracija regi1 = new Registracija.Registracija("LJ", "AB12");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Neustrezen znak!")]
        public void TestMethod2()
        {
            Registracija.Registracija regi2 = new Registracija.Registracija("LJ", "AB12-");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nisi izbral pravega območja!")]
        public void TestMethod3()
        {
            Registracija.Registracija regi3 = new Registracija.Registracija("AA", "AB123");
        }
    }
}
