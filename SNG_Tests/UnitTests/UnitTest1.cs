using Microsoft.VisualStudio.TestTools.UnitTesting;
using SNG_Tests;
namespace UnitTest_TestSNG

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDefineSymbolOfASCII_1()
        {
            double actual = new Test1().ChekRightEnter("56+");
            Assert.AreEqual(11111111111, actual);
        }

        [TestMethod]
        public void TestDefineSymbolOfASCII_2()
        {
            double actual = new Test1().ChekRightEnter("33");
            Assert.AreEqual(33, actual);
        }

        [TestMethod]
        public void TestDefineSymbolOfASCII_3()
        {
            double actual = new Test1().ChekRightEnter("-100");
            Assert.AreEqual(-100, actual);
        }

        [TestMethod]
        public void TestDefineSymbolOfASCII_4()
        {
            double actual = new Test1().ChekRightEnter("~");
            Assert.AreEqual(11111111111, actual);
        }
    }
}
