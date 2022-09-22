using BookingTicketApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{

    public class BaseClass
    {
        public static void TakeInput(ITakingInput it)
        {
            it.Input();

        }
        public static void Main()
        {
            bool dummyVar = true;
            Console.Write("userName : ");
            string userName = Console.ReadLine();
            Console.Write("password : ");
            string password = Console.ReadLine();
            LoginAccount user = new LoginAccount(userName, password);
            if (!Convert.ToBoolean(user.Checking()))  // CHECKING PASSWORD AND USERNAME
            {
                return;
            }

            while (dummyVar)
            {
                Console.WriteLine("1:Train Ticket Booking \n 2: Bus Ticket Booking \n 3: Flight Ticket Booking \n 4:Availability \n 5:My ticket Details");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            TakeInput(new TakingInput());
                            Passenger p = new Passenger(TakingInput.Name, TakingInput.Age, TakingInput.From, TakingInput.To, TakingInput.Year, TakingInput.Month, TakingInput.Day);
                            TrainTicketBooking ttb = new TrainTicketBooking();
                            ttb.Booking(p, TakingInput.BerthPreference);

                            break;

                        };
                    case 2:
                        {
                            TakingInput ti = new TakingInput();
                            Passenger p = new Passenger(TakingInput.Name, TakingInput.Age, TakingInput.From, TakingInput.To, TakingInput.Year, TakingInput.Month, TakingInput.Day);
                            BusTicketBooking ttb = new BusTicketBooking();
                            ttb.Booking(p, TakingInput.BerthPreference);

                            break;

                        };
                    case 3:
                        {
                            TakingInput ti = new TakingInput();
                            Passenger p = new Passenger(TakingInput.Name, TakingInput.Age, TakingInput.From, TakingInput.To, TakingInput.Year, TakingInput.Month, TakingInput.Day);
                            FlightTicketBooking ttb = new FlightTicketBooking();
                            ttb.Booking(p, TakingInput.BerthPreference);

                            break;

                        };
                    case 4:
                        {
                            ITicketReservation iac = new TrainTicketBooking();  //runtime polymorphism To call check method based on the object we are passing
                            iac.Check();
                            break;
                        };
                    case 5:
                        {
                            Console.WriteLine("Enter the Passenger_Id :");
                            int k = int.Parse(Console.ReadLine());
                            BookedTicketList tr = new FlightTicketBooking();
                            tr.MyBooking(k);
                            break;
                        };
                    default:
                        {
                            break;
                        };

                }
            }

        }
    }
}
