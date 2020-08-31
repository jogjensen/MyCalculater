using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculater;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MyCalculater.Tests
{
    [TestClass()]
    public class CalculaterTests
    {
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(9,Calculater.Multiply(3,3));
            Assert.AreEqual(3.30,Calculater.Multiply(1.10,3));
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(10,Calculater.Add(5,5));
            Assert.AreEqual(15,Calculater.Add(7.5,7.5));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(3,Calculater.Divide(9,3));
            Assert.AreEqual(10,Calculater.Divide(100,10));
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.AreEqual(10,Calculater.Subtract(15,5));
            Assert.AreEqual(7.5,Calculater.Subtract(15,7.5));
        }
    }
}