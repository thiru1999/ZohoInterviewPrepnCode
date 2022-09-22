using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoInvoiceManagement.Model
{
    internal class ItemContainer
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public ItemContainer(string ItemName,int ItemPrice)
        {
            this.ItemName = ItemName;
            this.ItemPrice = ItemPrice;
            Program.ItemId++;

        }

    }
}
