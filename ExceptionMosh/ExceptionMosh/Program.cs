

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                YoutubeApi api = new YoutubeApi();
                api.GetVideo("c# tutorial");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
