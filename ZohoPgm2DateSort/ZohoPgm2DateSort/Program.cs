using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoPgm2DateSort
{
    internal class Program
    {
        public static void DateSort(List<List<int>> inputDate)
        {
            List<int> year = new List<int>();
            var month = new List<int>();
            var day = new List<int>();
            Dictionary<int, List<List<int>>> mappingYearAndDayMonth = new Dictionary<int, List<List<int>>>();
            foreach(List<int> i in inputDate)
            {
                int k = 1;
                

                foreach(int j in i)
                {
                    if (k == 1)
                    {
                        day.Add(j);

                    }
                    if (k == 2)
                    {
                        month.Add(j);
                    }
                    if (k == 3)
                    {
                        year.Add(j);
                        //mappingYearAndDayMonth[j] = i;
                    }
                    k++;
                    
                    
                }
                k = 0;

            }
            foreach(List<int> i in inputDate)
            {
                List<List<int>> dummy = new List<List<int>>();


                if (mappingYearAndDayMonth.ContainsKey(i[2]))
                {
                    mappingYearAndDayMonth[i[2]].Add(i);

                }
                else
                {
                    dummy.Add(i);
                    mappingYearAndDayMonth[i[2]] = dummy;
                }
            }

            //List<int> key = new List<int>();
            //foreach(KeyValuePair<int, List<List<int>>> kvp in mappingYearAndDayMonth)
            //{
            //    key.Add(kvp.Key);
            //}
            //key.Sort();
        
            foreach(KeyValuePair<int,List<List<int>>> kvp in mappingYearAndDayMonth.OrderBy(k => k.Key))
            {
                int noOfOccurence = kvp.Value.Count;
                
                if (noOfOccurence > 1)
                {
                    int dummyddayCount = 0;
                    int dummymonthcount = 0;
                    int dummyddayCountValue = kvp.Value[0][0];
                    int dummymonthcountvAlue = kvp.Value[0][1];
                    List<int> DummyDay = new List<int>();
                    List<int> DummyMonth = new List<int>();
                    Dictionary<int, int> mappingMonthAndDay = new Dictionary<int, int>();
                    Dictionary<int, int> mappingDayAndMonth = new Dictionary<int, int>();

                    for (int i = 0; i < noOfOccurence; i++)
                    {
                        

                        DummyDay.Add(kvp.Value[i][0]);
                        DummyMonth.Add(kvp.Value[i][1]);
                        mappingDayAndMonth[kvp.Value[i][0]] = kvp.Value[i][1];
                        mappingDayAndMonth[kvp.Value[i][1]] = kvp.Value[i][0];


                        if (kvp.Value[i][0] == dummyddayCountValue)
                        {
                            dummyddayCount++;

                        }
                        if (kvp.Value[i][1] == dummymonthcountvAlue)
                        {
                            dummymonthcount++;

                        }


                    }
                  
                    if (dummyddayCount <= 1 && dummymonthcount <= 1)
                    {
                        DummyMonth.Sort();
                        for (int i = 0; i < noOfOccurence; i++)
                        {
                            Console.Write(mappingDayAndMonth[DummyMonth[i]] +" " + DummyMonth[i]+" "+ kvp.Key+" ");

                        }
                    
             
                    }
                    if (dummymonthcount > 1)
                    {
                        DummyDay.Sort();
                        for (int i = 0; i < noOfOccurence; i++)
                        {
                            Console.Write(DummyDay[i] + " " + mappingMonthAndDay[DummyDay[i]] + " " + kvp.Key+" ");

                        }
                    }

                    break;

                }
                else
                {

                    List<List<int>> opList = kvp.Value;
                    foreach(List<int> op in opList)
                    {
                        foreach(int i in op)
                        {
                            Console.Write(i + " ");
                        }

                    }
                    
                }
            }
            //year.Sort();
            //for(int i=1;i<year.Count;i++)
            //{
            //    int g = 0;
            //    if (year[i] < max)
            //    {
            //        mappingYearAndDayMonth[g] = inputDate[i];
            //    }
            //    if (year[i] == max)
            //    {
            //        if (month[i])

            //    }


            //}
            //int max = year[0];
            //for (int i = 1; i < year.Count; i++)
            //{
            //    if()

            //}
         

            //foreach(int i in year)
            //{
            //    List<int> opMappingList = mappingYearAndDayMonth[i];
            //    foreach(int j in opMappingList)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();

            //}
            



            //int minYear = year.Min();


        }
        public static void Main(string[] args)
        {
            List<List<int>> inputDateList = new List<List<int>>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n;i++) {
                List<int> dummyDateList = new List<int>();
                string[] inputDummyString = Console.ReadLine().Split(',');
                foreach(string j in inputDummyString)
                {
                    dummyDateList.Add(int.Parse(j));
                    
                }
                inputDateList.Add(dummyDateList);
                dummyDateList = null;
            }
            DateSort(inputDateList);
            
        }
    }
}
