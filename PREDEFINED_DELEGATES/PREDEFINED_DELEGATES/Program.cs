using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREDEFINED_DELEGATES
{
    

    public class Program
    {
     
        static void Main(string[] args)
        {
            Program p1= new Program();
            Func<int,int,int ,int>  ad = (x,y,z) =>
            {
                return x + y + z;

            };
            Action<int, int, int> ad1 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            int result = ad(10, 20, 30);
            ad1(50, 60, 85);
            Console.WriteLine(result);
       


        }
    }
}
