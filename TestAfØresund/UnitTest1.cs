
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ØresundBillet;

namespace TestAfØresund
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMCStreng()
        {
            MC mc = new MC();

            string a = mc.Køretøjet();

            Assert.AreEqual(a,"Øresund MC");
        }

        [TestMethod]
        public void TestMCPrisMed()
        {
            MC mc = new MC();

            decimal a = mc.Pris(true);

            Assert.AreEqual(a, 73m);
        }

        [TestMethod]
        public void TestMCPrisUden()
        {
            MC mc = new MC();

            decimal a = mc.Pris(false);

            Assert.AreEqual(a, 210m);
        }

        [TestMethod]
        public void TestBilStreng()
        {
            Bil bil = new Bil();

            string a = bil.Køretøjet();

            Assert.AreEqual(a, "Øresund Bil");
        }

        [TestMethod]
        public void TestBilPrisMed()
        {
            Bil bil = new Bil();

            decimal a = bil.Pris(true);

            Assert.AreEqual(a, 161m);
        }

        [TestMethod]
        public void TestBilPrisUden()
        {
            Bil bil = new Bil();

            decimal a = bil.Pris(false);

            Assert.AreEqual(a, 410m);
        }
    }
}
