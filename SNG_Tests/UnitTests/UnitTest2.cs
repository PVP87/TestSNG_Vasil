using Microsoft.VisualStudio.TestTools.UnitTesting;
using SNG_Tests;

namespace UnitTest_TestSNG

{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void DefineMaxValueOfNumber_1()
        {
            try
            {
                new Test2().DefineMaxValueOfNumber(55465413);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
