using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public abstract class BookedTicketList
    {
        public virtual void  MyBooking(int k)
        {

            Console.WriteLine($"Passenger_Name : {TakingInput.mappingPassenger[k].Name} \n Passenger Age : {TakingInput.mappingPassenger[k].Age}  \n Journey_Details : {TakingInput.mappingPassenger[k].From} {TakingInput.mappingPassenger[k].To}  \n Passenger Seat_Alloted : {TakingInput.mappingPassenger[k].SeatNumber}{TakingInput.mappingPassenger[k].BerthAlloted}");

        }

    }
}
