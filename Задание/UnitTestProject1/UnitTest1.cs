﻿using System;
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
            string c = "кристюшка";
            string expected = "тисюшкрка";
            char[] actual = Program.Shifr(c.ToCharArray());
            Assert.AreEqual(expected, actual);
        }
           
        [TestMethod]
        public void TestMethod2()
        {
            string c = " ";
            string expected = " ";
            char[] actual=  Program.Shifr(c.ToCharArray());
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void TestMethod3()
        {   
            try
            {
                string c = null;
                Program.Shifr(c.ToCharArray());

            }
            catch (InvalidCastException e)
            {
                Console.Write(e);
            }
        
        }
    }
}


