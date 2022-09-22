using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPrintBracketNo
{
    internal class Program
    {
        public static string PrintBracket(string str)
        {
            Stack<int> storingOpenParanCount = new Stack<int>();
            int count = 0;
            StringBuilder sb = new StringBuilder();
            foreach(char i in str)
            {
                if(i=='(')
                {
                    count++;
                    storingOpenParanCount.Push(count);
                    sb.Append(count);
                }
                if (i == ')')
                {
                    sb.Append(storingOpenParanCount.Pop());
                }
            }
            //StringBuilder sb = new StringBuilder();
            //int open = 0;int close = 0;
            //int dummyOpen = 0;
            //foreach(char i in str)
            //{
            //    if (i == '(')
            //    {
            //        open += 1;
            //        dummyOpen = open;
            //        sb.Append(open);

            //    }
            //    if (i == ')')
            //    {
            //        close = dummyOpen;
            //        sb.Append(close);
            //        dummyOpen -= 1;
            //    }
                
            //}
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string s = PrintBracket("(aa(bdc))p(dee)â€‹");
            Console.WriteLine(s);
        }
    }
}
