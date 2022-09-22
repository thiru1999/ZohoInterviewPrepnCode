using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public class TakingInput : ITakingInput// in order To reuse the code creating the class separately and also reducing the overhead on mainclass by creating this class<if i want To add any extra details i can simply add here.

    {
        public static string Name, From, To, BerthPreference;
        public static int Age, Day, Month, Year;
        public static int totalAvailableTrainTicket = 6;
        public static int totalAvailableUpperBerthTrainTicket = 2;
        public static int totalAvailableMiddleBerthTrainTicket = 2;
        public static int totalAvailableLowerBerthTrainTicket = 2;
        public static List<int> trainseatList = new() { 1, 2, 3, 4, 5, 6 };
        public static Dictionary<int, Passenger> mappingPassenger = new();


        public void Input()
        {
            Console.WriteLine("Enter the Passendger Details To Book Train Ticket......");
            Console.Write("Passenger_Name : ");
            Name = Console.ReadLine();
            Console.Write("Passenger_Age : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("From : ");
            From = Console.ReadLine();
            Console.Write("To : ");
            To = Console.ReadLine();
            Console.Write("Year : ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Month : ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Day : ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Berth_Position : ");
            BerthPreference = Console.ReadLine();
            
        }
    }
}
