using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactory.Product;
using CreationalDesignPatternFactory.ConcreteProduct;

namespace CreationalDesignPatternFactory.ConcreteFactory
{
    public class MobileFactory
    {
        public static Imobile CreateMobile(BrandType brand)
        {
            switch (brand)
            {
                case BrandType.samsung:
                    return new SamsunMobile();

                case BrandType.apple:
                    return new Apple();
                default:
                    throw new Exception("In=valid Mobile");
            }
        }
    }
}
