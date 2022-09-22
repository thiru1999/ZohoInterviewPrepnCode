using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Ticket_Application
{
    interface Ticket_Reservation
    {
        public void Booking(Passenger p, string Berth_preference);
    }
    interface IAvailabaility_Checking
    {
        public void Check();
    }
    internal class Base_Class
    {
        public static void Main()
        {
            bool dummy_var = true;
            Console.Write("Username : ");
            String Username = Console.ReadLine();
            Console.Write("Password : ");
            String Password = Console.ReadLine();
            Login_Account user = new Login_Account(Username, Password);
            if (!(Convert.ToBoolean(user.Checking())))  // CHECKING PASSWORD AND USERNAME
            {
                return;
            }

            while (dummy_var)
            {
                Console.WriteLine("1:Train Ticket Booking \n 2: Bus Ticket Booking \n 3: Flight Ticket Booking \n 4:Availability \n 5:My ticket Details");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Taking_Input ti = new Taking_Input();
                            Passenger p = new Passenger(Taking_Input.name, Taking_Input.age, Taking_Input.From, Taking_Input.To, Taking_Input.Year, Taking_Input.Month, Taking_Input.Day);
                            Train_ticket_booking ttb = new Train_ticket_booking();
                            ttb.Booking(p, Taking_Input.Berth_preference);

                            break;

                        };
                    case 2:
                        {
                            Taking_Input ti = new Taking_Input();
                            Passenger p = new Passenger(Taking_Input.name, Taking_Input.age, Taking_Input.From, Taking_Input.To, Taking_Input.Year, Taking_Input.Month, Taking_Input.Day);
                            Bus_Ticket_Booking ttb = new Bus_Ticket_Booking();
                            ttb.Booking(p, Taking_Input.Berth_preference);

                            break;

                        };
                    case 3:
                        {
                            Taking_Input ti = new Taking_Input();
                            Passenger p = new Passenger(Taking_Input.name, Taking_Input.age, Taking_Input.From, Taking_Input.To, Taking_Input.Year, Taking_Input.Month, Taking_Input.Day);
                            Flight_Ticket_Booking ttb = new Flight_Ticket_Booking();
                            ttb.Booking(p, Taking_Input.Berth_preference);

                            break;

                        };
                    /*case 4:
                        {
                            IAvailabaility_Checking iac = new Train_ticket_booking();  //runtime polymorphism to call check method based on the object we are passing
                            iac.Check();
                            break;
                        };*/
                    case 5:
                        {
                            Console.WriteLine("Enter the Passenger_Id :");
                            int k = int.Parse(Console.ReadLine());
                            Booked_Ticket_List tr = new Booked_Ticket_List();
                            tr.My_Booking(k);
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
