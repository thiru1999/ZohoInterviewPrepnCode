using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingAppln;

namespace TaxiBookingAppln.Controller
{
    public class CustomerBooksTaxi
    {
        private Customer Cust;
        private Taxi taxi;
        #region Booking Class

        public CustomerBooksTaxi(Customer cust)
        {
            Cust = cust;
          
        }
        #endregion
        public void Book(List<Taxi> localTaxiList) //LocalTaxi=>All Taxi Present
        {
            CheckingTaxiFreeOrNot ctfn = new CheckingTaxiFreeOrNot();  //Do dependancy injection using Runtime Polymorphism(Interface)
            List<Taxi> freeTimeTaxiList = new List<Taxi>();
            Program.BookingId++;



            foreach(Taxi t in localTaxiList)
            {
                if (ctfn.TimeConstraintChecking(t.BookedTime,Cust.PickupTime))
                {
                    freeTimeTaxiList.Add(t);

                }
            }
            Taxi BookedTaxi = ctfn.PlaceConstraintChecking(Cust.PickupPoint, freeTimeTaxiList, Cust.PickupTime);

            if (BookedTaxi != null)
            {
                char pickupPoint = Cust.PickupPoint;
                char dropPoint = Cust.DropPoint;
                int DistanceTravelled = Program.LocationPoint[dropPoint] - Program.LocationPoint[pickupPoint];
                int totalKm = DistanceTravelled * 15;
                int earnings = 100 + (totalKm - 5) * 10;
                BookedTaxi.Earnings = earnings;
                BookedTaxi.CurrentPos = dropPoint;
                BookedTaxi.BookedTime=Cust.PickupTime+DistanceTravelled;
                Console.WriteLine("Taxi Can Be Alloted");
                Console.WriteLine($"Taxi-{BookedTaxi.TaxiId} is Alloted");
                BookedTaxi.c = Cust;
            }
            else
            {
                Console.WriteLine("No Taxi Available");
            }

        }

    }
    
}
