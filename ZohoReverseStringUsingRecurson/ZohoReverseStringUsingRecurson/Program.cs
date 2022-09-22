using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoReverseStringUsingRecurson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            Char[] ReversingEachElement = input.ToCharArray();
            Array.Reverse(ReversingEachElement);
            StringBuilder StoringReverseArray = new StringBuilder();
            foreach(char i in ReversingEachElement)
            {
                StoringReverseArray.Append(i);

            }
            string output = StoringReverseArray.ToString();
            Console.WriteLine(output);*/

            //string FormattedInput=ReversingEachElement.ToString();
            //string[] inputArray = FormattedInput.Split(' ');
            //StringBuilder StoringReverseArray = new StringBuilder();
            //for(int iter = inputArray.Length-1; iter >=0; iter--)
            //{
            //    Array.Reverse(i);
            //    StoringReverseArray.Append(inputArray[iter]);
            //    StoringReverseArray.Append(" ");
            //}
            //string output = StoringReverseArray.ToString();
            //Console.WriteLine(output);
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            List<string> str = new List<string>();
            foreach(string iter in inputArray)
            {
                str.Add(iter);
            }
            string output = Program.reverse(str);
            Console.WriteLine(output);


        }
        public static List<string> ListItemRemoval(List<string> localList)
        {
            localList.RemoveAt(localList.Count - 1);
            return localList;
        }
        public static string reverse(List<string> str)
        {
            if(str.Count == 0)
            {
                return null;
            }
            else
            {
                return str[str.Count-1] +' '+ reverse(Program.ListItemRemoval(str));
            }

        }
    }
}
