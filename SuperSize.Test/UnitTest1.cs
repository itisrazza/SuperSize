using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
            //Fail("unit tests need to be written");
        }
    }
}
