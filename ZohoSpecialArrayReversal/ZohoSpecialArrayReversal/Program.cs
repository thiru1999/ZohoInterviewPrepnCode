using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoSpecialArrayReversal
{
    internal class Program
    {
        public static string ZohoSpecialArrayReversal(string str)
        {
           
            int i = 0;int j = str.Length-1;
            char[] str1 = str.ToCharArray();

            while(i<j)
            {
                if (char.IsLetter(str1[i])  && char.IsLetter(str1[j]))
                {
                    char a = str1[i];
                    char b = str1[j];
                    swap(ref a,ref b);
                    
                    str1[i] = a;
                    str1[j] = b;
                    j--;
                    i++;
                }
                if (!char.IsLetter(str[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetter(str[j]))
                {
                    j--;
                    continue;
                }
            }
            String s = new String(str1);
            return s;

        }
        public static void swap(ref char a,ref char b)
        {
            char temp = b;
            b = a;
            a = temp ;
        }
        static void Main(string[] args)
        {
            string s=ZohoSpecialArrayReversal("a&b");
         
            Console.WriteLine(s) ;
            
        }
    }
}
