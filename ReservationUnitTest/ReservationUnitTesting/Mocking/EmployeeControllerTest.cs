using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Mocking;
using Moq;
using ReservationUnitTest.Mocking.RefactoredCode;
using System.Net;
namespace ReservationUnitTesting.Mocking
{
    [TestFixture]
    internal class EmployeeControllerTest
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteFromDB()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);
            controller.DeleteEmployee(1);
            storage.Verify(s => s.DeleteEmployee(1));

        }
        [Test]

        public void DeleteEmployee_CheckingReturningObject_ReturnTypeOfRedirectObject()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);
            var op=controller.DeleteEmployee(1);
            Assert.That(op, Is.TypeOf(typeof( RedirectResult)));

        }


    }
}
