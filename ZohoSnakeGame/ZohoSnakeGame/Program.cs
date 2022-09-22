using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZohoSnakeGame.Model;

namespace ZohoSnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SnakeGameBoard s = new SnakeGameBoard(3, 3, new int[,] { { 1, 2 }, { 1, 3 } });
            Console.WriteLine(s.Move("r"));
            Console.WriteLine(s.Move("d"));
            Console.WriteLine(s.Move("r"));
            Console.WriteLine(s.Move("r"));

            Console.WriteLine(s.Move("r"));





        }
    }
}
