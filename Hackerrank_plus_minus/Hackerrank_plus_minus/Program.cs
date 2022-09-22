using System;
class Hackerrank_plus_minus
{
    public static void Main()
    {
        int n;
        int one = 0;
        int minus_one = 0;
        int zerop = 0;
        /*double res_one;
        double res_minus_one;
        double res_zerop;*/
        n = int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        foreach(int i in arr)
        {
            if (i >= 1)
            {
                one++;
            }
            if (i < 0)
            {
                minus_one++;
            }
            if (i == 0)
            {
                zerop++;
            }
        }
        //string s1 = string.Format("{0:D}", );
        decimal Pos = (decimal)one / n;
        decimal Neg = (decimal)minus_one / n;
        decimal Zer = (decimal)zerop / n;
        Console.WriteLine(string.Format("{0:0.000000}", Pos));
        Console.WriteLine(string.Format("{0:0.000000}", Neg));
        Console.WriteLine(string.Format("{0:0.000000}", Zer));

    }
}