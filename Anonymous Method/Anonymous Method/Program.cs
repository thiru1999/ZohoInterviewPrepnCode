using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method
{
    public delegate string Anonymous_Method_delegate(string name);


    public class Program1
    {
        static void Main(string[] args) 
        {
            
            Anonymous_Method_delegate obj = delegate (string name)
            {
                return "hello" + name;
            };
            string s = obj("kumar");
            Console.WriteLine(s);


        }
    }
}
