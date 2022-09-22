using DynamicLinkedLibraryForRailwayTickeBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking_System
{
    public class BookTicketContainer
    {
        public static int Total_Available_Upper_Berth_Seats = 1;
        public static int Total_Available_Middle_Berth_Seats = 1;
        public static int Total_Available_Lower_Berth_Seats = 1;
        public static int Total_Available_RAC_Seats = 1;
        public static int Total_Available_WL_Seats = 1;

        public static Queue<int> RAC_Que_List = new Queue<int>();
        public static Queue<int> WL_Que_List = new Queue<int>();
        public static List<int> BookedTickeList = new List<int>();

        public static List<int> LowerBerthPosition = new List<int> { 1};
        public static List<int> MiddleBerthPosition = new List<int> { 1 };
        public static List<int> UpperBerthPosition = new List<int> { 1 };
        public static List<int> RacBerthPosition = new List<int> { 1 };
        public static List<int> WlBerthPosition = new List<int> { 1 };

        public static Dictionary<int, Passenger> Mapping_passenger = new Dictionary<int, Passenger>(); 

        public void Booking_Ticket_With_Prefernce(Passenger p,int berth_info,string seat_position)
        {
            p.Seat_Number = berth_info;
            p.Berth_Alloted = seat_position;
            Mapping_passenger[Passenger.id] = p;
            BookedTickeList.Add(Passenger.id);
            Console.WriteLine($"Ticket Booked Succesfully For passenger_id {Passenger.id} in  the berth{seat_position}");

        }
        public void add_to_RAC(Passenger p, int berth_info, string seat_position)
        {
            p.Seat_Number = berth_info;
            p.Berth_Alloted = seat_position;
            Mapping_passenger[Passenger.id] = p;
            RAC_Que_List.Enqueue(Passenger.id);
            Console.WriteLine($"Ticket Booked Succesfully For passenger_id {Passenger.id} in  the berth{seat_position}");

        }
        public void add_to_WL(Passenger p, int berth_info, string seat_position)
        {
            p.Seat_Number = berth_info;
            p.Berth_Alloted = seat_position;
            Mapping_passenger[Passenger.id] = p;
            WL_Que_List.Enqueue(Passenger.id);
            Console.WriteLine($"Ticket Booked Succesfully For passenger_id {Passenger.id} in  the berth{seat_position}");

        }
        public void Cancel_Ticket(int passenger_id)
        {
            Passenger p = Mapping_passenger[passenger_id];
            Mapping_passenger.Remove(passenger_id);
            BookedTickeList.Remove(passenger_id);
            int position_booked = p.Seat_Number;
            Console.WriteLine("Cancelled Successfully ............");
            if (p.Berth_Alloted=="L")
            {
                BookTicketContainer.Total_Available_Lower_Berth_Seats++;
                BookTicketContainer.LowerBerthPosition.Add(position_booked);
            }
            else if (p.Berth_Alloted == "U")
            {
                BookTicketContainer.Total_Available_Upper_Berth_Seats++;
                BookTicketContainer.UpperBerthPosition.Add(position_booked);
            }
            else if (p.Berth_Alloted == "M")
            {
                BookTicketContainer.Total_Available_Middle_Berth_Seats++;
                BookTicketContainer.MiddleBerthPosition.Add(position_booked);
            }

            if (RAC_Que_List.Count>0)
            {
                Passenger passengerfromRAC = Mapping_passenger[RAC_Que_List.Dequeue()];
                int positionRAC = passengerfromRAC.Seat_Number;
                RacBerthPosition.Add(positionRAC);
                Total_Available_RAC_Seats++;
                if (WL_Que_List.Count>0)
                {
                    Passenger passengerfromWL = Mapping_passenger[WL_Que_List.Dequeue()];
                    int positionWL = passengerfromWL.Seat_Number;
                    WlBerthPosition.Add(positionWL);
                    passengerfromWL.Seat_Number = RacBerthPosition[0];
                    passengerfromWL.Berth_Alloted = "RAC";
                    RacBerthPosition.Remove(0);
                    RAC_Que_List.Enqueue(passengerfromWL.Passenger_id);
                    Total_Available_WL_Seats++;
                    Total_Available_RAC_Seats--;
                }
                Base_class.BookTicket(passengerfromRAC);

            }

        }
        public void printpassenger()
        {
            foreach (Passenger p in Mapping_passenger.Values)
            {
                Console.WriteLine("Passenger Id:" + p.Passenger_id);
                Console.WriteLine("Passenger Name:" + p.Name);
                Console.WriteLine("Passenger Age:" + p.Age);
                Console.WriteLine("Berth Alloted:" + p.Berth_Alloted);
            }
        }
    }
}

