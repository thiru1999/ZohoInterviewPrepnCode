using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public interface ITicketReservation
    {
        public void Booking(Passenger p, string berthPreference);
        public void Check();

    }

}
