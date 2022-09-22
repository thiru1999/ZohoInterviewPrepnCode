using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public int Product_id { get;  set; }
        public string Product_name { get;  set; }
        public int product_price { get;  set; }
        public bool validate()
        {
            var isvalid = true;
            if (String.IsNullOrWhiteSpace(Product_name))
            {
                isvalid = false;
            }
            return isvalid;


        }

    }
}

