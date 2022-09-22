using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoBitonicGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readline = Console.ReadLine();
            string[] stringArray = readline.Split(',');
            int[] input = new int[stringArray.Length];
            int j = 0;
            foreach (string i in stringArray)
            {
                input[j] = int.Parse(i);
                j++;
            }
            List<int> evenPosElement = new List<int>();
            List<int> oddPosElement = new List<int>();
            evenPosElement.Add(input[0]);
            evenPosElement.Add(input[2]);
            oddPosElement.Add(input[1]);


            for(int i = 3; i < input.Length ; i++)
            {
                if (i % 2 == 0)
                {
                    evenPosElement.Add(input[i]);
                }
                else
                {
                    oddPosElement.Add(input[i]);
                }

            }
            evenPosElement.Sort();
            oddPosElement.Sort();
            oddPosElement.Reverse();
            oddPosElement.ForEach(item => evenPosElement.Add(item));
            foreach(int i in evenPosElement)
            {
                Console.Write(i + " ");
            }


        }
    }
}
