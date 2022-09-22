using System;
using System.Collections.Generic;
using TaxiBookingAppln.Controller;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingAppln
{
    public class Program
    {

        private static List<int> bookingId = new List<int>();

        public static List<int> BookingIdList
        {
            get { return bookingId; }
            set { bookingId = value; }
        }


        private static List<Taxi> taxiList = new List<Taxi>();

        public static List<Taxi> TaxiList
        {
            get { return taxiList; }
            set { taxiList = value; }
        }
        public static int BookingId = 0;
        public static int TaxiId = 0;


        public static int GeneralCustomerId;

        public static Dictionary<char, int> LocationPoint = new Dictionary<char, int> { { 'a', 1 }, { 'b',2},
                                                    { 'c',3},{'d',4 },{'e',5 },{'f',6 } };

        public static void Display()
        {
            foreach(Taxi t in TaxiList)
            {
                Console.WriteLine($"Taxi- {t.TaxiId}        Total Earnings-{t.Earnings}");
                Console.WriteLine($"{BookingId}     {t.c.CustomerId}    {t.c.PickupPoint}   {t.c.DropPoint}     {t.c.PickupTime}    {t.BookedTime}  {t.Earnings}");
            }

        }

        static void Main()
        {
            Taxi t1 = new Taxi();
            TaxiList.Add(t1);

            Taxi t2 = new Taxi();
            TaxiList.Add(t2);

            Taxi t3 = new Taxi();
            TaxiList.Add(t3);

            Taxi t4 = new Taxi();
            TaxiList.Add(t4);


            Console.WriteLine("1 => to Book ,Press any Other Button to Close");
            int input = 1;
            do
            {
                input = int.Parse(Console.ReadLine());
                int id = int.Parse(Console.ReadLine());
                char pp = char.Parse(Console.ReadLine());
                char dp = char.Parse(Console.ReadLine());
                int pt = int.Parse(Console.ReadLine());
                Customer c = new Customer(id, pp, dp, pt);
                CustomerBooksTaxi booksTaxi = new CustomerBooksTaxi(c);
                booksTaxi.Book(TaxiList);



            }
            while (input == 1);

            Display();



        }
    }
}
