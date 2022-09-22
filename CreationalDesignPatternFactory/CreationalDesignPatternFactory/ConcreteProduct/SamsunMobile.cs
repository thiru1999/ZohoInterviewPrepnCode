using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactory.Product;
namespace CreationalDesignPatternFactory.ConcreteProduct
{
    public class SamsunMobile : Imobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung Mobile Created");
        }
    }
}
