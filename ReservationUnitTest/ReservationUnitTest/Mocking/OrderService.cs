using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationUnitTest.Mocking
{
    public class OrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage _storage)
        {
            this._storage = _storage;
        }

        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);

            // Some other work

            return orderId;
        }
    }

    public class Order
    {
    }

    public interface IStorage
    {
        int Store(object obj);
    }
}

