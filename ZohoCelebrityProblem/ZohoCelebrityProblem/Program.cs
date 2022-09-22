using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoCelebrityProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = celebrity(new int[,] { { 0, 1, 0 }, { 0, 0, 0 }, { 0, 1, 0 } }, 3);
            Console.WriteLine(op);
        }

        public static int celebrity(int[,] M, int n)
        {

            int dummy = 0;

            int index = 0;
            //Your code here
            for (int i = 0; i < n; i++)
            {
                int flag = 0;
                for (int j = 0; j < n; j++)
                {
                    if (M[i, j] == 1)
                    {
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    dummy++;
                    index = i;
                }
            }
            if (dummy == 0 || dummy > 1)
            {
                return -1;
            }
            return index;

        }
    }
}
