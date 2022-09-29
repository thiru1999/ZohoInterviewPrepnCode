using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPblm1ReverseString
{
    internal class Program
    {
        public static void Reverse(string str,int index1,int index2)
        {
            int dummy;

            int strLen = 0;
            string op = "";
            //string opPrint = "";
            //Finding Count Loop
            foreach(char i in str)
            {
                strLen += 1;

            }
            try
            {
                if (strLen < index1)
                {
                    dummy = 0;
                    throw new Exception("Index must be small than the strlen");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            
            //StringBuilder sb = new StringBuilder();
            for(int i = 0; i < strLen; i++)
            {
                
                if (i >= index1 &&i<=index2)
                {
                    op += str[i];
                    //sb.Append(str[i]);
                }
                else
                {
                    Console.Write(str[i]);
                }

            }
            //string sbString = sb.ToString();
            //Finding Count of Sbstring;
            int sbStringCount = 0;
            foreach (char i in op)
            {
                sbStringCount += 1;

            }
            for(int j = sbStringCount-1; j >= 0; j--)
            {
                Console.Write(op[j]);   //Printing in reverse;

            }
           

        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            
            Reverse(inputString,index1,index2);
        }
    }
}
