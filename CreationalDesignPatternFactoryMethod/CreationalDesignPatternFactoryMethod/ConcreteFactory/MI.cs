using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactoryMethod.Ifactory;
using CreationalDesignPatternFactoryMethod.ConcreteProduct;
namespace CreationalDesignPatternFactoryMethod.ConcreteFactory
{
    public class MI : IBrands
    {
        public IMobile SelectBrands(MobileType mobileType)
        {
            switch (mobileType)
            {
                case MobileType.Mi10T:
                    return new Mi10T();
                default:
                    throw new Exception("Invalid Mobile");
            }
        }
    }
}
