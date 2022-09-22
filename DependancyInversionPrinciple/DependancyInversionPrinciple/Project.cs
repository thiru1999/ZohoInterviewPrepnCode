using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInversionPrinciple
{
    public class Project
    {
        public static void Execution(Developer dev)
        {
            dev.Develop();

        }
        public static void Main()
        {
            Project.Execution(new Frontend());
            Project.Execution(new Backend());


            /*Backend dev = new Backend();
            dev.implement();*/
            //instead of doing like the above now we are depending on the interface and creatimg the object for the same by using runtime polymorphism we are shifting the dependancy on the interface not on concrete class
        }

    }
}
