using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Acm.bl;
namespace Acm.Bl.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer();
            customer.Name = "thirumani kumar v";
            string expected = "thirumani kumar v";
            string Actual=customer.Name;
            Assert.AreEqual(expected, Actual);


        }
    }
}
