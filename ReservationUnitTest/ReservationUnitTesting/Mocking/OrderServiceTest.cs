using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Mocking;
using Moq;
using NUnit.Framework;

namespace ReservationUnitTesting.Mocking
{
    [TestFixture]
    internal class OrderServiceTest
    {
        [Test]
        public void PlaceOrder_OrderInteractingWithStorage_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();
            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));
        }
    
    }
}
