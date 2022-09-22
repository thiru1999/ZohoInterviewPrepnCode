using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRemoveUnbalancedParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            int open=0, close = 0;
            string expression = Console.ReadLine();
            string expressionCopy = expression;
            string dummyExpression = string.Empty;
            int lenght=expression.Length;
            for(start = 0, end = lenght-1; start < lenght; start++, end--)
            {
                if (expression[start] == '(')
                {
                    open++;
                }
                else if(expression[start] == ')')
                {
                    open--;
                    
                }
                if (expression[end] == ')')
                {
                    close++;
                }
                else if (expression[end] == '(')
                {
                    close--;
                   
                }
                if (open < 0)
                {
                    dummyExpression= expressionCopy.Remove(start,1);
                    expressionCopy = dummyExpression;
                    open = 0;
                }
                if (close < 0)
                {
                    dummyExpression= expressionCopy.Remove(end,1);
                    expressionCopy = dummyExpression;
                    close = 0;
                }

            }
            Console.WriteLine(expressionCopy);
        }
    }
}
