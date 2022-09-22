using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoLookAndSaySequence
{
    internal class Program
    {
        static void LookAndSay(int n)
        {
            string s = "1";
            char previous = '1';
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                StringBuilder op = new StringBuilder();


                for (int j = 0; j < s.Length; j++)
                {
                    if (previous == s[j])
                    {
                        count++;
                    }
                    else
                    {
                        op.Append(count);
                        op.Append(previous);
                        count = 1;
                    }
                    if (j == s.Length - 1)
                    {
                        op.Append(count);
                        op.Append(s[j]);
                        break;
                    }
                    previous = s[j];

                }
                s = op.ToString();
                previous = s[0];
                count = 0;
                Console.WriteLine(s);
                //if (i == n - 1)
                //{
                //    return s ;


                //}
            }

            //return null;
        }
        static void Main(string[] args)
        {
           LookAndSay(4) ;
        }
    }
}
