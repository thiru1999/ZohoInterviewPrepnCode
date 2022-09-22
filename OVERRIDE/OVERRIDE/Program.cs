using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERRIDE
{
    public class Program
    {
        public virtual void method1()
        {
            Console.WriteLine("Method1 called");
           
        }
       
    }
    public class program1 : Program
    {
        public void meth()
        {
            Console.WriteLine("just calling");
        }
        public override void method1()
        {
            Console.WriteLine("Override1 method1 called");
        }



    }
    public class testclass: program1
    {
        public static void Main()
        {
            Program p1 =new program1();
            p1.method1();
       


        } 
    }
}
