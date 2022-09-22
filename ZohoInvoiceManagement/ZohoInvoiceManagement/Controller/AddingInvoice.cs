using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZohoInvoiceManagement.Model;

namespace ZohoInvoiceManagement.Controller
{
    public class AddingInvoice
    {
        public void AddingInvoiceToExistingCustomer(int idToMapCustomer)
        {
            ItemContainer dummyItemContainer=null;

            foreach (KeyValuePair<int,Customer> pair in Program.MappingCustIdWithCustomer)  //Checking the customerId to find Customer 
            {                                                                              //Then assigning the Invoice to that XCustomer
                if (pair.Key == idToMapCustomer)
                {
                    Console.WriteLine("1:HeadPhone Rs 400");
                    Console.WriteLine("2:Speaker Rs 1000");
                    Console.WriteLine("3:SdCard Rs 500");
                    Console.WriteLine("4:Battery Rs 6000");
                    int dummy = int.Parse(Console.ReadLine());
                    foreach(KeyValuePair<int,ItemContainer> itemcontainerPair in Program.MappingItemWithId) //Finding the Item in the Dictionary with itemid
                    {
                        if (itemcontainerPair.Key == dummy)
                        {
                            dummyItemContainer = itemcontainerPair.Value;  //Found Item that have ItemName and ItemPrice
                        }
                    }
                    Invoice invoice1 = new Invoice(dummyItemContainer.ItemName, dummyItemContainer.ItemPrice);
                    Program.MappingInvoiceIdWithInvoice[Program.InvoiceId] = invoice1;
                    pair.Value.CustomersInvoiceList.Add(invoice1);  //Adding the invoice to the MappedCustomerId Customer 


                }
            }


        }
       
    }
}
