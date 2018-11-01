using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задание;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string c = "кристюшка";
            string expected = "рксиюткша";
            char [] actual = Program.Shifr(c.ToCharArray());
            String abc = new String (actual);
            Assert.AreEqual(expected,abc);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string c = " ";
            string expected = " ";
            char[] actual = Program.Shifr(c.ToCharArray());
            String abc = new String(actual);
            Assert.AreEqual(expected, abc);

        }
        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                string c = null;
                Program.Shifr(c.ToCharArray());

            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }
    }

}
