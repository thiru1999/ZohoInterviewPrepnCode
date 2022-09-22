using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatternFactoryMethod.Iproduct;

namespace CreationalDesignPatternFactoryMethod.Iproduct
{
    public class SamsungNote10 : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("SamsungS10 Mobile cREATED");
        }
    }
}
