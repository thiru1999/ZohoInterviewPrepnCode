using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        
        /*public static void Main()
        {
            *//* Tuple<int, string> T1 = new Tuple<int, string>(89, "ghs");
             Console.WriteLine(T1.Item1);*//*
            var mytuple = Tuple.Create(20, "dubuide", 6554);
            Console.WriteLine(mytuple);

        }
   */
        public static void Main()
        {
            Console.WriteLine("Downloading ....");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
            

        }
      
    }
}
