using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPrepFindingStringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noOfInput = int.Parse(Console.ReadLine());
            string WordToSearch = Console.ReadLine().ToLower();
            Dictionary< String,int> mappingCountAndInputString = new Dictionary<string,int>();
            List<string[]> inputString = new List<string[]>();
            for(int i = 0; i < noOfInput; i++)
            {
                string inputDummy = Console.ReadLine().ToLower();
                string[] dummy = inputDummy.Split(' ');
                int count = 0;
               
                foreach(string str in dummy)
                {
                    if (str == WordToSearch)
                    {
                        count++;
                        
                    }
                }
                mappingCountAndInputString[inputDummy] = count;

            }
            foreach(KeyValuePair<string,int> kvp in mappingCountAndInputString.OrderBy(key=>key.Value))
            {
                Console.WriteLine(kvp.Key);

            }

        }
    }
}
