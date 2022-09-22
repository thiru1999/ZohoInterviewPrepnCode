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
    internal class ErrorLoggerTest
    {
        private ErrorLogger _error;
        [SetUp]
        public void Setup()
        {
            _error = new ErrorLogger();
        }

        [Test]
        public void Log_CheckLogStatus_SetTheErrorProperty()
        {
            _error.Log("snmksnf");
            Assert.That(_error.LastError, Is.EqualTo("snmksnf"));


        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]

        public void Log_CheckLogStatusNull_ThrowsException(string error)
        {
            Assert.That(() => _error.Log(error), Throws.ArgumentNullException);

            //Assert.That(() => _error.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
            

        }
    }
}
