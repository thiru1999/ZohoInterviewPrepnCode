using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoho2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> inputDateList = new List<List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> dummyDateList = new List<int>();
                string[] inputDummyString = Console.ReadLine().Split(',');
                foreach (string j in inputDummyString)
                {
                    dummyDateList.Add(int.Parse(j));

                }
                inputDateList.Add(dummyDateList);
                dummyDateList = null;
            }
            DateSort(inputDateList);

        }
        public static void DateSort(List<List<int>> inputDate)
        {
            int minday = inputDate[0][0];
            int minmonth = inputDate[0][1];
            int minyear = inputDate[0][2];



            for (int i = 0; i < inputDate.Count; i++)
            {
                if (minyear > inputDate[i][2])
                {
                    minday = inputDate[i][2];
                    minmonth = inputDate[i][1];
                    minyear = inputDate[i][0];

                }
                if (minyear == inputDate[i][2])
                {
                    if (minmonth > inputDate[i][1])
                    {
                        minday = inputDate[i][2];
                        minmonth = inputDate[i][1];
                        minyear = inputDate[i][0];



                    }
                    else if (minmonth == inputDate[i][1])
                    {
                        if (minday > inputDate[i][0])
                        {
                            minday = inputDate[i][2];
                            minmonth = inputDate[i][1];
                            minyear = inputDate[i][0];

                        }

                    }
                  
                }
                


            }
            Console.Write(minday+" "+minmon);
        }
    }
}
