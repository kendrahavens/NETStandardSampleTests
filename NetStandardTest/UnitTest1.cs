using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;

namespace NetStandardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c1 = new Class1();
            Assert.IsNotNull(c1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.Fail("Intentionally fails");
        }

#if NET472
        [TestMethod]
        public void Net472OnlyTest()
        {
            Assert.IsTrue(true);
        }
#endif
    }
}
