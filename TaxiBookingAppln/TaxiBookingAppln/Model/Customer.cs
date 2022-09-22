using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingAppln
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public char PickupPoint { get; set; }

        public char DropPoint { get; set; }
        public int PickupTime { get; set; }

        public Customer(int GeneralCustomerId,char PickupPoint,char DropPoint,int PickupTime)
        {
            CustomerId = GeneralCustomerId;
            this.PickupPoint = PickupPoint;
            this.DropPoint = DropPoint;
            this.PickupTime = PickupTime;
        }



    }
}
