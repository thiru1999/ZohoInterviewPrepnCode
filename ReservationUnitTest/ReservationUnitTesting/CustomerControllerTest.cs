using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ReservationUnitTest.Fundamental;

namespace ReservationUnitTesting
{
    [TestFixture]
    internal class CustomerControllerTest
    {
        [Test]
        public void ActionResult_IdIsZero_ReturnNotFoundObject()
        {
            CustomerController customer = new CustomerController();
            ActionResult op= customer.GetCustomer(0);

            Assert.That(op, Is.TypeOf<NotFound>());

            Assert.That(op, Is.InstanceOf<NotFound>());

        }

        public void ActionResult_IdIsInteger_ReturnNotFoundObject()
        {
            CustomerController customer = new CustomerController();
            ActionResult op = customer.GetCustomer(5);

            Assert.That(op, Is.TypeOf<Ok>());

            Assert.That(op, Is.InstanceOf<Ok>());


        }

    }
}
