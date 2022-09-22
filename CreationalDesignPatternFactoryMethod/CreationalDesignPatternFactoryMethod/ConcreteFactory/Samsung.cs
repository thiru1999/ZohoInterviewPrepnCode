using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactoryMethod.Ifactory;
using CreationalDesignPatternFactoryMethod.ConcreteProduct;
using CreationalDesignPatternFactoryMethod.Iproduct;

namespace CreationalDesignPatternFactoryMethod.ConcreteFactory
{
    public class Samsung:IBrands
    {
        public IMobile SelectBrands(MobileType mobileType)
        {
            switch (mobileType)
            {
                case MobileType.SamsungNote10:
                    return new SamsungNote10();
                default:
                    throw new Exception("Invalid Mobile");
            }
        }
    }
}
