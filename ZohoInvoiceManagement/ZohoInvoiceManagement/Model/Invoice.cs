using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoInvoiceManagement.Model
{
    public class Invoice
    {
        public List<string> ItemName = new List<string>();
        public List<int> ItemPrice = new List<int>();
        public Invoice(string ItemName,int Price)
        {
            this.ItemName.Add(ItemName);
            this.ItemPrice.Add(Price);
            Program.InvoiceId++;
        }

    }
}
