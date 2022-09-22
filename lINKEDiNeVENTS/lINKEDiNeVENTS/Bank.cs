using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lINKEDiNeVENTS
{
    class Bank
    {
        public void Adding(int amount,ref int total)
        {
            total += amount;
            Console.WriteLine("The Balance Amount is" + total);
        }
        public void Print(int amount,ref int total)
        {
            if (total > 500)
            {
                Console.WriteLine("Savings Reached");
            }
        }

    }
}
