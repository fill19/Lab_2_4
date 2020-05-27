using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 20, -30, 50, -60, -42, 17, -38, 1 };
            int result = ConsoleApplication11.Program.Sum(array);
            Assert.AreEqual(result, -83);
        }

    }
}

