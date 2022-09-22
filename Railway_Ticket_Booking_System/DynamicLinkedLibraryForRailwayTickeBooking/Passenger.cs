using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking_System
{
    public class Passenger
    {
        public static int id = 1;
        public int Passenger_id;//get reflected on all all class ,incremented when its constructor called
        public string Name, Berthpreference, Berth_Alloted;
        public int Age,Seat_Number;
        public Passenger(int Age,string Name,string Berthpreference)
        {
            this.Name = Name;
            this.Age = Age;
            this.Berthpreference = Berthpreference;
            Passenger_id = id + 1; ;
            Seat_Number = 1;
            Berth_Alloted = " ";

        }

    }
}
