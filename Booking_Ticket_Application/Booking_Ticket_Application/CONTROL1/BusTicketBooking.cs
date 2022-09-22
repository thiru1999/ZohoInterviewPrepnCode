using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public class BusTicketBooking : BookedTicketList, ITicketReservation
    {
        int totalAvailableBusTicket = 5;
        List<int> busSeatList = new List<int> { 1, 2, 3, 4, 5 };

        public void Booking(Passenger p, string berthPreference)
        {
            if (totalAvailableBusTicket<0)
            {
                Console.WriteLine("Sorry No ticket Available....");
                return;
            }
            else
            {
                p.SeatNumber = busSeatList[0];
                p.BerthAlloted = berthPreference;
                busSeatList.RemoveAt(0);
                TakingInput.mappingPassenger[p.PassengerId] = p;
                totalAvailableBusTicket--;
                Console.WriteLine($"Bus Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");

            }
        }

        public void Check()
        {
            Console.WriteLine($"Total Available Ticket : {totalAvailableBusTicket} ");
        }

        public override void MyBooking(int k)
        {

            Console.WriteLine($"Bus Ticket Booked ......\nPassenger_Name : {TakingInput.mappingPassenger[k].Name} \n Passenger Age : {TakingInput.mappingPassenger[k].Age}  \n Journey_Details : {TakingInput.mappingPassenger[k].From} {TakingInput.mappingPassenger[k].To}  \n Passenger Seat_Alloted : {TakingInput.mappingPassenger[k].SeatNumber}{TakingInput.mappingPassenger[k].BerthAlloted}");

        }


    }
}
