using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInversionPrinciple
{
    internal class Frontend : Developer
    {
        public void Develop()
        {
            this.implement();
        }
        public void implement()
        {
            Console.WriteLine("Write Javascript Code");
        }
    }
}
