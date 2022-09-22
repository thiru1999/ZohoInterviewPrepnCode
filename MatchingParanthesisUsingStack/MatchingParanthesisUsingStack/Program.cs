using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingParanthesisUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParanthesesIsMatchingOrNot("((hello))"));
            Console.WriteLine(ParanthesesIsMatchingOrNot("((((hello))"));
        }
        public static bool ParanthesesIsMatchingOrNot(string str)
        {
            Stack<char> StoringParantheses = new Stack<char>();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    StoringParantheses.Push(str[i]);

                }
                if (str[i] == ')')
                {
                    if (StoringParantheses.Count > 0)
                    {
                        StoringParantheses.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (StoringParantheses.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
