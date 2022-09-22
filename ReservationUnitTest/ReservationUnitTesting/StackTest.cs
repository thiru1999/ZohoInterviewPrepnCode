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
    internal class StackTest
    {
        //No need to check the private Field (ie)List
        [Test]
        public void push_CheckingNull_ThrowsException()
        {
            Stacks<string> s = new Stacks<string>();
            Assert.That(() => s.Push(null), Throws.ArgumentNullException);

        }

       
    }
}
