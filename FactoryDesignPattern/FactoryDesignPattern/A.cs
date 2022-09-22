using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class A : IgetRate
    {
        public int GetRate()
        {
            int rate = 10;
            return rate;

        }
    }
}
