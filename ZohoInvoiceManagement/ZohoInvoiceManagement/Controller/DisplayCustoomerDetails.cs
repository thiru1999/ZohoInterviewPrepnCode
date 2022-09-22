using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoInvoiceManagement.Model;
using System.Threading.Tasks;

namespace ZohoInvoiceManagement.Controller
{
    public class DisplayCustoomerDetails:IDisplayDetails
    {
        public void Display()
        {
            Console.WriteLine("Cust_Id   CustName         Mobile         Address");
            foreach (KeyValuePair<int, Customer> CustomerPair in Program.MappingCustIdWithCustomer)
            {
                Console.WriteLine($"{CustomerPair.Key}        {CustomerPair.Value.Name}    {CustomerPair.Value.MobileNo}     {CustomerPair.Value.Address}");

            }
        }
    }
}
