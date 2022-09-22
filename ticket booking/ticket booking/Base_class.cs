using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking_System
{
    public class Base_class
    {
        public static void BookTicket(Passenger p)
        {
            BookTicketContainer btk = new BookTicketContainer();
            if (BookTicketContainer.Total_Available_WL_Seats == 0)
            {
                Console.WriteLine("No Tickets Available");
                return;

            }
            if((p.Berthpreference=="L" && BookTicketContainer.Total_Available_Lower_Berth_Seats>0) || (p.Berthpreference == "U" && BookTicketContainer.Total_Available_Upper_Berth_Seats > 0) || (p.Berthpreference == "M" && BookTicketContainer.Total_Available_Middle_Berth_Seats > 0))
            {
                Console.WriteLine("Preferred Berth Available...............");
                if (p.Berthpreference.Equals("L"))
                {
                    Console.WriteLine("Lower Berth Given");
                    btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.LowerBerthPosition[0], "L");
                    BookTicketContainer.Total_Available_Lower_Berth_Seats--;
                    BookTicketContainer.LowerBerthPosition.RemoveAt(0);
                }
                else if (p.Berthpreference.Equals("M"))
                {
                    Console.WriteLine("Middle Berth Given");
                    btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.MiddleBerthPosition[0], "M");
                    BookTicketContainer.Total_Available_Middle_Berth_Seats--;
                    BookTicketContainer.MiddleBerthPosition.RemoveAt(0);
                }
                else if (p.Berthpreference.Equals("U"))
                {
                    Console.WriteLine("Upper Berth Given");
                    btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.UpperBerthPosition[0], "U");
                    BookTicketContainer.Total_Available_Upper_Berth_Seats--;
                    BookTicketContainer.UpperBerthPosition.RemoveAt(0);
                }
            }

            else if (BookTicketContainer.Total_Available_Lower_Berth_Seats>0)
            {
                Console.WriteLine("Lower Berth Given");
                btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.LowerBerthPosition[0], "L");
                BookTicketContainer.Total_Available_Lower_Berth_Seats--;
                BookTicketContainer.LowerBerthPosition.RemoveAt(0);

            }
            else if (BookTicketContainer.Total_Available_Middle_Berth_Seats > 0)
            {
                Console.WriteLine("Middle Berth Given");
                btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.MiddleBerthPosition[0], "M");
                BookTicketContainer.Total_Available_Middle_Berth_Seats--;
                BookTicketContainer.MiddleBerthPosition.RemoveAt(0);


            }
            else if (BookTicketContainer.Total_Available_Upper_Berth_Seats > 0)
            {
                Console.WriteLine("Upper Berth Given");
                btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.UpperBerthPosition[0], "U");
                BookTicketContainer.Total_Available_Upper_Berth_Seats--;
                BookTicketContainer.UpperBerthPosition.RemoveAt(0);

            }
            else if (BookTicketContainer.Total_Available_RAC_Seats>0)
            {
                Console.WriteLine("RAC Seat Given");
                btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.RacBerthPosition[0], "RAC");
                BookTicketContainer.Total_Available_RAC_Seats--;
                BookTicketContainer.RacBerthPosition.RemoveAt(0);


            }
            else if (BookTicketContainer.Total_Available_WL_Seats > 0)
            {
                Console.WriteLine("WL Seat Given");
                btk.Booking_Ticket_With_Prefernce(p, BookTicketContainer.WlBerthPosition[0], "RAC");
                BookTicketContainer.Total_Available_WL_Seats--;
                BookTicketContainer.WlBerthPosition.RemoveAt(0);


            }

        }
        

        public static void Cancel_Ticket(int id)
        {
            BookTicketContainer btk = new BookTicketContainer();
            btk.Cancel_Ticket(id);


        }
        public static void Main()
        {
            bool dummy_variable = true;
            while (dummy_variable)
            {
                Console.WriteLine("enter the choice \n 1:Book Ticket \n 2:Cancel Ticket \n 3:Available Ticket \n 4:Booked Ticket \n 5:Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Passenger Details : NAME,AGE,BERTHPREFERENCE-L/M/U");
                            string name = Console.ReadLine();
                            int age = int.Parse(Console.ReadLine());
                            string BerthPreference = Console.ReadLine();
                            Passenger p = new Passenger(age, name, BerthPreference);
                            BookTicket(p);  //creating instance for the passenger ,ie storing each passenger as object with separate data and functionality
                            break; 

                        };
                    case 2:
                        {
                            Console.WriteLine("enter the passenger ID to cancel the ticket ");
                            int id = int.Parse(Console.ReadLine());
                            Cancel_Ticket(id);
                            break;
                            
                        };
                    case 4:
                        {
                            BookTicketContainer bkt = new BookTicketContainer();
                            bkt.printpassenger();
                            break;
                        };

                }

            }

        }
    }
}
