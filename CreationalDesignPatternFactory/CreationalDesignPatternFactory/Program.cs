using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactory.ConcreteFactory;
using CreationalDesignPatternFactory.Product;
namespace CreationalDesignPatternFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imobile mobile=MobileFactory.CreateMobile(BrandType.samsung);
            mobile.GetMobile();
        }
    }
}
