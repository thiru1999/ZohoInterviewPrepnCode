using System;
namespace ACM
{

    public class Customer
    {
        private string name;
        private string address;
        public int Customer_id { get; private set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Email
        {
            get; set;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

    }
}