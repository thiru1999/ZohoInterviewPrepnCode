using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Fundamental;

namespace ReservationUnitTesting
{
    [TestFixture]
    internal class DemeritPointCalculatorTset
    {
        [Test]
        public void CalculateDemeritPoints_CheckingMaxSpeed_ShouldReturException()
        {
            DemeritPointCalculator dpct = new DemeritPointCalculator();
            Assert.That(() => dpct.CalculateDemeritPoints(400), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void CalculateDemeritPoints_ChekingLessThan65_ShouldReturException()
        {
            DemeritPointCalculator dpct = new DemeritPointCalculator();

            Assert.That(dpct.CalculateDemeritPoints(40), Is.EqualTo(0));

        }
        [Test]
        public void CalculateDemeritPoints_CheckingStateOfDemeritPoint_ShouldReturException()
        {
            DemeritPointCalculator dpct = new DemeritPointCalculator();
            dpct.CalculateDemeritPoints(70);
            Assert.That(dpct.demeritPoints, Is.GreaterThan(0));

        }
    }
}
