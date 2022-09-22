using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinDelegate
{
    public delegate void Mydel(decimal price,ref decimal fee);
    public class Program
    {
         

        static void Main(string[] args)
        {
            Shipping destination;
            string dest;
            do
            {
                dest = Console.ReadLine();
                destination = Shipping.SelectDestination(dest);
                Console.WriteLine("eNter the price");
                decimal price = decimal.Parse(Console.ReadLine());
                Mydel  mydel= destination.FeeCaln;
                if (destination.isHigRisk)
                {
                    mydel += delegate (decimal price1, ref decimal fee)
                    {
                        fee += 25.0m;
                    };
                }
                 decimal fee1 = 0.0m;
                mydel(price, ref fee1);
                Console.WriteLine(fee1);

            }
            while (dest!="Exit") ;
        }
    }
}
