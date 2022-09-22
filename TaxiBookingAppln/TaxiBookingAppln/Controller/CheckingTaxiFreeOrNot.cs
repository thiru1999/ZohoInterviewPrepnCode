using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaxiBookingAppln.Controller
{
    public class CheckingTaxiFreeOrNot
    {
 
        public bool TimeConstraintChecking(int BookedTime, int PickupTime) //BookedTime=>Taxi Booked Till That Time
        {
            if (PickupTime>BookedTime)
            {
                return true;
            }
            //Simplified Time Constraints
            else 
            {
                return false;

            }

        }
        public  Taxi PlaceConstraintChecking(char PickupPoint, List<Taxi> localTaxiList,int pickupTime)
        {
    
            List<KeyValuePair<int, Taxi>> MappingMinDistWithTaxi = new List<KeyValuePair<int, Taxi>>();
            List<int> CurrentTaxiLocationValue = new List<int>(); //Storing the Difference value
            foreach(Taxi t in localTaxiList)  //use Linq
            {
                t.MinDistane=Math.Abs(Program.LocationPoint[t.CurrentPos] -Program.LocationPoint[PickupPoint]); //storing the Difference which helps to find taxi which is near to the customer pickup point
                CurrentTaxiLocationValue.Add(t.MinDistane);
                MappingMinDistWithTaxi.Add(new KeyValuePair<int, Taxi>(t.MinDistane, t));
                
            }
            MappingMinDistWithTaxi.Sort((x, y) => x.Key.CompareTo(y.Key));
            //Changing Taxi Min Distance Variable Dynamically for each Booking.
            if (MappingMinDistWithTaxi[CurrentTaxiLocationValue[0]].Key == MappingMinDistWithTaxi[CurrentTaxiLocationValue[1]].Key)
            {
                if (MappingMinDistWithTaxi[0].Value.Earnings <= MappingMinDistWithTaxi[1].Value.Earnings)
                {
                    return MappingMinDistWithTaxi[0].Value;
                }
                else
                {
                    return MappingMinDistWithTaxi[1].Value;
                }

            }
            else
            {
                return MappingMinDistWithTaxi[0].Value;
            }


            return null;
            

        }

    }
}
