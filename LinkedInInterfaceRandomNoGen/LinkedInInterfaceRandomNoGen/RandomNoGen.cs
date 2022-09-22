using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInInterfaceRandomNoGen
{
    public class RandomNoGen : IRandomizable
    {
        public void GetRandomNum(int ub)
        {
            Random r = new Random();
            //Console.WriteLine(r.Next(ub));
            Double k =r.NextDouble();
            Console.WriteLine(k * ub);
        }
    }
}
