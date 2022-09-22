using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZohoInvoiceManagement.Model;

namespace ZohoInvoiceManagement.Controller
{
    public class AddingItemToInvoice
    {
        public void AddingExtraItemToExistingInvoice(int InvoiceId)
        {
            ItemContainer dummyItemContainer = null;
            foreach (KeyValuePair<int,Invoice> invoicePair in Program.MappingInvoiceIdWithInvoice)
            {
                if (invoicePair.Key == InvoiceId)
                {
                    Console.WriteLine("1:HeadPhone Rs 400");
                    Console.WriteLine("2:Speaker Rs 1000");
                    Console.WriteLine("3:SdCard Rs 500");
                    Console.WriteLine("4:Battery Rs 6000");
                    int dummy = int.Parse(Console.ReadLine());
                    foreach (KeyValuePair<int, ItemContainer> itemcontainerPair in Program.MappingItemWithId) //Finding the Item in the Dictionary with itemid
                    {
                        if (itemcontainerPair.Key == dummy)
                        {
                            dummyItemContainer = itemcontainerPair.Value;  //Found Item that have ItemName and ItemPrice
                        }
                    }
                    invoicePair.Value.ItemName.Add(dummyItemContainer.ItemName); //Adding the item to the Invoice ItemList
                    invoicePair.Value.ItemPrice.Add(dummyItemContainer.ItemPrice);

                }
            }

        }
    }
}
