using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //defining the delegates
    public delegate void add_delegate(int x, int y );
    public delegate void name_delegate(string x );


    public class program
    {
        public void add_method(int a ,int b)
        {
            Console.WriteLine(a+b);

        }
        public void name(string name)
        {
            Console.WriteLine("hi" + name);

        }

    }
    public class program1
    {
        static void Main(string[] args)
        {
            program p = new program();
            //instantiating the delegate 
            add_delegate ad = new add_delegate(p.add_method);
            name_delegate nd=new name_delegate(p.name);
            ad(100, 200);
            nd("kumar ");

        }
    }
}
