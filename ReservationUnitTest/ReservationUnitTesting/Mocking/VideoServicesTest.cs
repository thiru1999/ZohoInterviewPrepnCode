using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Mocking;
using Moq;

namespace ReservationUnitTesting.Mocking
{
    [TestFixture]
    internal class VideoServicesTest
    {
        private Mock<IfileReader> _mockFileReader;
        private ReservationUnitTest.Mocking.VideoService _service;

        [SetUp]
        public void Setup()
        {
            _mockFileReader  = new Mock<IfileReader>();
            _service = new VideoService(_mockFileReader.Object);
        }
        [Test]
        public void ReadVideoTitle_CheckingTheOpIsNull_ReturnErrorMessage()
        {
            _mockFileReader.Setup(mcfr => mcfr.Read("video.txt")).Returns(" ");
            //VideoService vs = new VideoService(new FakeFileReader()); =>For Dependancy Injection using Constructor
            //string op=vs.ReadVideoTitle(new FakeFileReader());  => For Dependancy Injection using Method
            string op = _service.ReadVideoTitle();
            Assert.That(op, Does.Contain("error").IgnoreCase);       
        }


    }
}
