namespace BookingTicketApplication
{
    public class Passenger
    {
        public string Name;
        public int Age;
        public string From;
        public string To;
        public DateTime DateofJourney;
        public static int Id = 1;
        public int PassengerId;
        public int SeatNumber;
        public string BerthAlloted;


        public Passenger(string name, int age, string from, string to, int year, int month, int day)
        {
            this.Name = name;
            this.Age = age;
            this.From = from;
            this.To = to;
            DateTime DateOfJourney = new DateTime(year, month, day);
            PassengerId = Id++;
            SeatNumber = 0;
            BerthAlloted = "";


        }
    }
}
