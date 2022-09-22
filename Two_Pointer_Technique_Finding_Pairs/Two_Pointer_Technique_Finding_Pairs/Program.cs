using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Pointer_Technique_Finding_Pairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2,7,11,15 };
            
            int target = 9;
            Program pg = new Program();
            
            int[] result= pg.TwoSum(numbers, target);
            foreach(int i in result)
            {
                Console.Write(i+" ");
            }


        }
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int[] result = new int[2];

            while (start < end)
            {
                if ((numbers[start] + numbers[end]) == target)
                {
                    result[0] = start + 1;
                    result[1] = end + 1;
                    break;


                }
                else if ((numbers[start] + numbers[end]) > target)
                {
                    end--;

                }
                else if ((numbers[start] + numbers[end]) < target)
                {
                    start++;

                }


            }
            return result;



        }
    }
}
