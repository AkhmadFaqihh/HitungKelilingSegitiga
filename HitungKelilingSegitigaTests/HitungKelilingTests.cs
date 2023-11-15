using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitTest.Tests
{
    [TestClass()]
    public class HitungKelilingTests
    {
        [TestMethod()]
        public void HKSegitigaTest()
        {
            HitungKeliling HK = new HitungKeliling();
            Assert.AreEqual(30, HK.HKSegitiga(10, 10, 10));
        }
    }
}