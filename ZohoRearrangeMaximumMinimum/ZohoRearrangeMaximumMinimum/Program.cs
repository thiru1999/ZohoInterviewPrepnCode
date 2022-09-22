using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRearrangeMaximumMinimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');
            int inputArrayLength = inputArray.Length;
            List<int> inputList = new List<int>();
            List<int> RearrangedList = new List<int>();
            int maxVariable;
            int minVariable;
            foreach(string i in inputArray)
            {
                inputList.Add(int.Parse(i));
            }
            for(int iter = 0; iter <inputArrayLength/2+1; iter++)
            {
                if (inputList.Count != 0)
                {
                    maxVariable = inputList.Max();
                    inputList.Remove(maxVariable);
                    RearrangedList.Add(maxVariable);

                }
                else
                {
                    break;

                }
                if (inputList.Count != 0)
                {
                    minVariable = inputList.Min();
                    inputList.Remove(minVariable);
                    RearrangedList.Add(minVariable);


                }
                else
                {
                    break;
                }
            }
            foreach(int i in RearrangedList)
            {
                Console.Write(i + " ");
            }

        }
    }
}
