using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoInvoiceManagement.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public List<Invoice> CustomersInvoiceList = new List<Invoice>();


        public Customer(string Name,string Address,string MobileNumber)
        {
            this.Name = Name;
            this.Address = Address;
            this.MobileNo = MobileNo;
            Program.CustomerId++;
        }
    }
}
