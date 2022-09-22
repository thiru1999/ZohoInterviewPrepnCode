using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n=Console.ReadLine();
            bool result=int.TryParse(n,out int k);    
            if (result == false)                  //checking whether the input is string or number.
            {
                string s = n.ToLower();
                StringBuilder sb = new StringBuilder();
                foreach(char c in s)
                {
                    if (c>='a' && c <= 'z')
                    {
                        sb.Append(c);
                    }
                }
                string revs = "";
                for (int i = sb.Length - 1; i >= 0; i--) //String Reverse  
                {
                    revs += sb[i].ToString();
                }
                string outpu = sb.ToString();
                if (revs == outpu) // Checking whether string is palindrome or not  
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }
                Console.ReadKey();
            }
            else      // checking the no pallindrome or not
            {
                int temp = k;
                int sum = 0;
                int rem;
                while (k > 0)
                {
                    rem = k % 10;
                    sum = sum * 10 + rem;
                    k = k / 10;
                    Console.WriteLine("hii");
                    Console.WriteLine(sum);


                }
                if (temp==sum)
                {
                    Console.WriteLine("Pallindrome");

                }
                else
                {
                    Console.WriteLine("Not Pallindrome");
                }
            }


        }
    }
}
