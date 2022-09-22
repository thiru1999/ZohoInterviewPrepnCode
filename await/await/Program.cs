using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace await
{
    public class Program
    {
            public  static void Main()
            {
                Console.WriteLine("Downloading ....");
                Download();
                Console.ReadLine();
            }
            
            
        
            static async void Download1()
            {
                Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Download Complete");
                });
            }
    }
}
