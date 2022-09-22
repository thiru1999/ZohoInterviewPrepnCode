using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public class FlightTicketBooking : BookedTicketList,ITicketReservation
    {
        int totalAvailableFlightTicket = 5;
        List<int> flightSeatList = new List<int> { 1, 2, 3, 4, 5 };



        public void Booking(Passenger p, string berthPreference)
        {
            if (totalAvailableFlightTicket < 0)
            {
                Console.WriteLine("Sorry No ticket Available....");
                return;

            }
            else
            {
                p.SeatNumber = flightSeatList[0];
                p.BerthAlloted = berthPreference;
                flightSeatList.RemoveAt(0);
                TakingInput.mappingPassenger[p.PassengerId] = p;
                totalAvailableFlightTicket--;
                Console.WriteLine($"Bus Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");
            }
        }

        public void Check()
        {
            Console.WriteLine($"Total Available Ticket : {totalAvailableFlightTicket} ");
        }

        public override void MyBooking(int k)
        {

            Console.WriteLine($"Flight Ticket Booked.....\nPassenger_Name : {TakingInput.mappingPassenger[k].Name} \n Passenger Age : {TakingInput.mappingPassenger[k].Age}  \n Journey_Details : {TakingInput.mappingPassenger[k].From} {TakingInput.mappingPassenger[k].To}  \n Passenger Seat_Alloted : {TakingInput.mappingPassenger[k].SeatNumber}{TakingInput.mappingPassenger[k].BerthAlloted}");

        }


    }
}
