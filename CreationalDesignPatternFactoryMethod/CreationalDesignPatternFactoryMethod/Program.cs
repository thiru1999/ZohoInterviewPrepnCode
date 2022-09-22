using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactoryMethod.ConcreteProduct;
using CreationalDesignPatternFactoryMethod.ConcreteFactory;
using CreationalDesignPatternFactoryMethod.Ifactory;
using CreationalDesignPatternFactoryMethod.Iproduct;

namespace CreationalDesignPatternFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBrands samsung = new Samsung(); //We have top Decide the Factoy themn Product will get Manufactured
            IMobile sam= samsung.SelectBrands(MobileType.SamsungNote10);
            sam.CreateMobile();

            
        }
    }
}
