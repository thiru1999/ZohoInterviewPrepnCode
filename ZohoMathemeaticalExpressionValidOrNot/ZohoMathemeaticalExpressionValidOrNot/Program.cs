using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoMathemeaticalExpressionValidOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathematicalExpression = Console.ReadLine();
            int flag = 0;
            if (BracketMatching(mathematicalExpression))
            {
                for(int iter=0;iter<mathematicalExpression.Length;iter++)
                {
                    if (mathematicalExpression[iter] =='+' || mathematicalExpression[iter] == '-'|| mathematicalExpression[iter] == '*')
                    {
                        if (char.IsLetter( mathematicalExpression[iter-1]) && char.IsLetter(mathematicalExpression[iter + 1]))
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("NotValid");


                }
            }
        }
        public static bool BracketMatching(string str)
        {
            Stack<char> StoringBrackets = new Stack<char>();
            foreach(char i in str)
            {
                if (i == '(')
                {
                    StoringBrackets.Push(i);
                }
                if (i == ')')
                {
                    StoringBrackets.Pop();
                }
            }
            if (StoringBrackets.Count == 0)
            {
                return true;
            }
            return false;

        }
    }
}
