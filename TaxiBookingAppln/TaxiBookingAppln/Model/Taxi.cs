using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingAppln
{
    public class Taxi
    {
        public int Earnings { get; set; }
        public int MinDistane { get; set; }

        public int BookedTime { get; set; } = 0;
        public int TaxiId { get; set; }


        public char CurrentPos { get; set; } = 'a';
        public Customer c { get; set; }
        


        public Taxi()
        {
            this.TaxiId=Program.TaxiId;
            Program.TaxiId++;
        }
    }
}
