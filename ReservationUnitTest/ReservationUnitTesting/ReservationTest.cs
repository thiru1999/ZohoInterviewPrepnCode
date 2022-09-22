using NUnit.Framework;
using ReservationUnitTest;
using System;

namespace ReservationUnitTesting
{
    [TestFixture]
    public class ReservationTest    
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            Reservation reserve = new Reservation();
            User user1 = new User();
            user1.IsAdmin = true;
            //Act
            bool op = reserve.CanBeCancelledBy(user1);

            //Assert

            Assert.IsTrue(op);

            Assert.That(op == true); //One Other Type to Test The Code
            Assert.That(op, Is.True);//One Other Type to Test The Code
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            User user1 = new User();
            Reservation reserve = new Reservation();
            reserve.MadeBy = user1;

            bool op=reserve.CanBeCancelledBy(user1);

            Assert.IsTrue(op);
            
        }

        [Test]

        public void CanBeCancelledBy_NotTheSameUser_ReturnFalse()
        {
            var user1 = new User();
            Reservation reserve = new Reservation();
            reserve.MadeBy = new User();

            bool op = reserve.CanBeCancelledBy(user1);

            Assert.IsFalse(op);
        }
    }
}
