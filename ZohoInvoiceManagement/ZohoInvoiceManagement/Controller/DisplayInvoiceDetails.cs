using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoInvoiceManagement.Model;
using System.Threading.Tasks;
namespace ZohoInvoiceManagement.Controller
{
    public class DisplayInvoiceDetails : IDisplayDetails
    {
        public void Display()
        {
            foreach (KeyValuePair<int, Invoice> InvoicePair in Program.MappingInvoiceIdWithInvoice)
            {
                Console.WriteLine("Invoice_No   " + InvoicePair.Key);
                Console.WriteLine("ItemName            UnitPrice");
                for (int i = 0; i < InvoicePair.Value.ItemName.Count; i++)
                {
                    Console.WriteLine(InvoicePair.Value.ItemName[i] + "             " + InvoicePair.Value.ItemPrice[i]);
                }
                Console.WriteLine($"TotalItem:     {InvoicePair.Value.ItemName.Count}          TotalPrice:     {InvoicePair.Value.ItemPrice.Sum()}");


            }
        }
    }
}
