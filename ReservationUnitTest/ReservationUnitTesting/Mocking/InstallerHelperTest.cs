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

    internal class InstallerHelperTest
    {
        private Mock<IFileDownloader> _MockDownloadFile;
        private InstallerHelper _installHelper;
        [SetUp]
        public void Setup()
        {
            _MockDownloadFile = new Mock<IFileDownloader>();
            _installHelper = new InstallerHelper(_MockDownloadFile.Object);
        }


        [Test]
        public void DownloadInstaller_CheckingEmptyFile_ReturnException()
        {
            _MockDownloadFile.Setup(df => df.DownloadFile("http://example.com/CustomerName/installer", null)).Throws<WebException>();
            var op = _installHelper.DownloadInstaller("CustomerName", "installer");
            Assert.That(op, Is.False);
        }

    }
}
