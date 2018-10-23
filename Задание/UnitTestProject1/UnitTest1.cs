using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задание;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string S = "Привет игорь";
            string expected = "рПвитеи огьр";
            char[] res = Program.shifr(S);
            string actiual = Convert.ToString(res);
            Assert.AreEqual(expected,actiual);
        }
    }
}
