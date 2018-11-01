using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringStart
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //проверяет, начинается ли строка с определенного слова
            StringAssert.StartsWith("Hello world", "Hello");
        }
        
    }
}
