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
    internal class HTMLFormatterTest
    {
        [Test]
        public void FormatAsBold_MakingStirngBold_ReturnBoldString()
        {
            HTMLFormatter html = new HTMLFormatter();

            string op=html.FormatAsBold("abdsc");

            //Specific Testing

            Assert.That(op, Is.EqualTo("<stRong>abdsc</strong>").IgnoreCase);

            //General Testing

            Assert.That(op, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(op, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(op, Does.Contain("</strong>").IgnoreCase); 


        }

    }
}
