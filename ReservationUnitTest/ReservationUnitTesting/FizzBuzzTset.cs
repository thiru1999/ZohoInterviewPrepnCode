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
    internal class FizzBuzzTset
    {

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void GetOutput_Check3OR5_ShouldReturnFizzBuzz(int number)
        {
            string op = FizzBuzz.GetOutput(number);

            Assert.That(op, Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void GetOutput_Check3_ShouldReturnFizz()
        {
            string op = FizzBuzz.GetOutput(3);

            Assert.That(op, Is.EqualTo("Fizz"));

        }

        [Test]

        public void GetOutput_Check5_ShouldReturnFizz()
        {
            string op = FizzBuzz.GetOutput(5);

            Assert.That(op, Is.EqualTo("Buzz"));

        }

    }
}
