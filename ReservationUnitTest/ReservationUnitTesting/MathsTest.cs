using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ReservationUnitTest;
using ReservationUnitTest.Fundamental;

namespace ReservationUnitTesting
{
    [TestFixture]
    internal class MathsTest
    {
        private Maths _m1;
        [SetUp]
        public void Setup() //Name(Setup) can be Anything
        {
            _m1 = new Maths();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {

            int op = _m1.Add(1, 3);

            Assert.That(op, Is.EqualTo(4));
        }
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_FirstArgumentGreater_ReturnFirstArguement(int a ,int b,int expected)
        {
            int op=_m1.Max(a, b);
            Assert.That(op, Is.EqualTo(expected));

        }

        [Test]

        public void GetOddNumber_NoGreaterThanZero_ReturnOddNumberArray()
        {
            IEnumerable<int> op = _m1.GetOddNumbers(5);
            Assert.That(op, Is.Ordered);
            Assert.That(op, Is.Unique);
            Assert.That(op, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(op, Does.Contain(1));
            Assert.That(op.Count(), Is.EqualTo(3));
        }
        //[Test]
        //public void Max_SecondArgumentGreater_ReturnSecondArguement()
        //{
        //    int op = _m1.Max(1, 2);
        //    Assert.That(op, Is.EqualTo(2));

        //}
        //[Test]

        //public void Max_SameNumber_ReturnNumber()
        //{
        //    int op = _m1.Max(1, 1);
        //    Assert.That(op, Is.EqualTo(1));

        //}
    }
}
