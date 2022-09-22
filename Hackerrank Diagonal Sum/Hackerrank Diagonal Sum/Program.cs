using System;
class Diagonal_Difference
{
    public static void Main()
    {
        int n;
        int sum1 = 0;
        int sum2=0;
        n = Int32.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        for (var i = 0; i < n; i++)
        {
            string[] numList=new string[n];
            numList = Console.ReadLine().Split(' ');
            for (var j = 0; j < n; j++)
            {
                arr[i, j] = Convert.ToInt32(numList[j]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    sum1 = sum1 + arr[i, j];
                }
                if (j == (n- i - 1)){
                    sum2 = sum2 + arr[i, j];    

                }
            }
        }
        Console.WriteLine(Math.Abs((sum1-sum2)));
    }
}