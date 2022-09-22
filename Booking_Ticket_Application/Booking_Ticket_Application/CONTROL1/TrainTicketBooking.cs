using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public class TrainTicketBooking : BookedTicketList, ITicketReservation
    {
        
        
        public void Booking(Passenger p, string berthpreference)
        {
            if (TakingInput. totalAvailableTrainTicket <= 0)
            {
                Console.WriteLine("No tickets Available ,Please try other mode of transport ");
                return;
            }
            else if (berthpreference == "U" && TakingInput.totalAvailableUpperBerthTrainTicket > 0 || berthpreference == "M" && TakingInput.totalAvailableMiddleBerthTrainTicket > 0 || berthpreference == "L" && TakingInput.totalAvailableLowerBerthTrainTicket > 0)
            {
                if (berthpreference == "U")
                {
                    p.SeatNumber = TakingInput.trainseatList[0];
                    p.BerthAlloted = "U";
                    TakingInput.trainseatList.RemoveAt(0);
                    TakingInput.totalAvailableTrainTicket--;
                    TakingInput.totalAvailableUpperBerthTrainTicket--;
                    TakingInput.mappingPassenger[p.PassengerId] = p;
                    Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");

                }
                if (berthpreference == "M")
                {
                    p.SeatNumber = TakingInput.trainseatList[0];
                    p.BerthAlloted = "M";
                    TakingInput.trainseatList.RemoveAt(0);
                    TakingInput.totalAvailableTrainTicket--;
                    TakingInput.totalAvailableMiddleBerthTrainTicket--;
                    TakingInput.mappingPassenger[p.PassengerId] = p;
                    Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");


                }
                if (berthpreference == "L")
                {
                    p.SeatNumber = TakingInput.trainseatList[0];
                    p.BerthAlloted = "L";
                    TakingInput.trainseatList.RemoveAt(0);
                    TakingInput.totalAvailableTrainTicket--;
                    TakingInput.totalAvailableMiddleBerthTrainTicket--;
                    TakingInput.mappingPassenger[p.PassengerId] = p;
                    Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");

                }

            }
            else if (TakingInput.totalAvailableMiddleBerthTrainTicket >0)
            {
                p.SeatNumber = TakingInput.trainseatList[0];
                p.BerthAlloted = "M";
                TakingInput.trainseatList.RemoveAt(0);
                TakingInput.totalAvailableTrainTicket--;
                TakingInput.totalAvailableMiddleBerthTrainTicket--;
                TakingInput.mappingPassenger[p.PassengerId] = p;
                Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");


            }
            else if (TakingInput.totalAvailableLowerBerthTrainTicket >0)
            {
                p.SeatNumber = TakingInput.trainseatList[0];
                p.BerthAlloted = "L";
                TakingInput.trainseatList.RemoveAt(0);
                TakingInput.totalAvailableTrainTicket--;
                TakingInput.totalAvailableMiddleBerthTrainTicket--;
                TakingInput.mappingPassenger[p.PassengerId] = p;
                Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");

            }
            else if (TakingInput.totalAvailableUpperBerthTrainTicket >0)
            {
                p.SeatNumber = TakingInput.trainseatList[0];
                p.BerthAlloted = "U";
                TakingInput.trainseatList.RemoveAt(0);
                TakingInput.totalAvailableTrainTicket--;
                TakingInput.totalAvailableUpperBerthTrainTicket--;
                TakingInput.mappingPassenger[p.PassengerId] = p;
                Console.WriteLine($"Ticket Booked Successfully for the passenger {p.Name} in the seat {p.SeatNumber}{p.BerthAlloted}");

            }
        }

        public void Check()
        {
            Console.WriteLine($"Total Available Ticket : {TakingInput.totalAvailableTrainTicket} \n Availabale Lower Berth {TakingInput.totalAvailableLowerBerthTrainTicket} \n Available Upper Berth {TakingInput.totalAvailableUpperBerthTrainTicket} \n Available Middle Berth {TakingInput.totalAvailableMiddleBerthTrainTicket}");
        }

        public override void MyBooking(int k)
        {

            Console.WriteLine($"Train Ticket Booked.....\nPassenger_Name : {TakingInput.mappingPassenger[k].Name} \n Passenger Age : {TakingInput.mappingPassenger[k].Age}  \n Journey_Details : {TakingInput.mappingPassenger[k].From} {TakingInput.mappingPassenger[k].To}  \n Passenger Seat_Alloted : {TakingInput.mappingPassenger[k].SeatNumber}{TakingInput.mappingPassenger[k].BerthAlloted}");

        }




    }
}
