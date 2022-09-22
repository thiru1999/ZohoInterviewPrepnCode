using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatesAnonymousLambda
{
    public delegate void ArithmeticAdd(int a, int b);
    internal class Program
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine("The addition Result is " + a + b);
        }
        public static void Subtarction(int a, int b)
        {
            Console.WriteLine($"The Sub is {a-b}");
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("The Multiplication Result is " + a * b);
        }

        static void Main()
        {
            //ArithmeticAdd sum = new ArithmeticAdd(add);
            //ArithmeticAdd sum = Add;
            //sum += Subtarction;
            //sum += Multiplication;
            //sum(10,5);

            ArithmeticAdd sum = Add;
            sum(10, 5);
            //delegate (int a, int b) { Console.WriteLine(a + b); };  //Anonymous Function


            Action<int, int> sub = (int a, int b) => Console.WriteLine(a - b);  //Anonymous with Lambda Expression
            sub(10, 5);


        }
    }
}
