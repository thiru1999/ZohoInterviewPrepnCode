using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Types of constraints:
// where T : IComparable
// where T : Product (a class)
// where T : struct
// where T : class ('has to be a reference type' - mosh)
// where T : new() ('has to have a default constructor' - mosh)


namespace GenericsMosh
{
    public class Program
    {
        public static T Max<T>(T a, T b) where T:IComparable
        {
            return a.CompareTo(b)==1 ? a : b;

        }

        static void Main(string[] args)
        {
           //Console.WriteLine( Max<int>(2, 1));
            var number = new Nullable<int>();
            Console.WriteLine(number.HasValue);
            Console.WriteLine(number.GetValueOrDefault());
            
        }
    }
}
