using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_addition_operator_overloading
{
    internal class Matrix:Object
    {
        int a, b, c, d;
        public Matrix(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {   //operator overloading
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";

        }


        static void Main(string[] args)
        {
            Matrix obj = new Matrix(1,2,3,4);
            Matrix obj2 = new Matrix(0,1,2,3);
            
            Matrix obj3 = obj + obj2;
            Console.WriteLine(obj3);
            int K = 10;
            Console.WriteLine(K);



        }
    }
}
