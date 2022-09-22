using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ACMTEST

{
    [TestClass]
    public class CustomerTest
    {

    
        [TestMethod]
        public void NameTestValid()
        {
            Customer  customer = new Customer();
            /*customer.Name = "thirumani ";
            string expected = "thirumani";
            string actual = customer.Name;
            Assert.AreEqual(expected, actual);*/
        }

    }
}
