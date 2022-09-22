using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoFindingSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k = FindingSubstring("GeeksForGeeks", "orwdfef");
            Console.WriteLine(k);
        }
        public static int FindingSubstring(String wholeString,string strToFind)
        {
            int flag = 0;
            int l;
            for(int i = 0; i < wholeString.Length; i++)
            {
                l = i;
                if (wholeString[i] == strToFind[0]){
                    l++;
                    for(int j = 1; j < strToFind.Length; j++)
                    {
                        if (strToFind[j] != wholeString[l])
                        {
                            flag = 0;
                            break;

                        }
                        else
                        {
                            l++;
                            flag = 1;
                        }

                    }
                    if (flag == 1)
                    {
                        return i;
                    }

                }
            }
            return -1;
        }
    }
}
