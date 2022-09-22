using System;
namespace ACM.BL
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
        public bool validate()
        {
            var isvalid = true;
            if (String.IsNullOrWhiteSpace(Name))
            {
                isvalid = false;
            }
            return isvalid;
         

        }

    }
}