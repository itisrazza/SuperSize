using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SuperSize.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(5000);
        }

        [TestMethod]
        public void BadTest()
        {
            Assert.Fail("unit tests need to be written");
        }
    }
}
