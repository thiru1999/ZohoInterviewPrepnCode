using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactory.Product;

namespace CreationalDesignPatternFactory.ConcreteProduct
{
    internal class Apple : Imobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Apple Mobile Created");
        }
    }
}
