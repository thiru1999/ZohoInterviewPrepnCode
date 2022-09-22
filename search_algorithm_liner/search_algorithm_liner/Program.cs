using System;
public class Linear_Search_2d_array
{
    public static int search(int[][] inputs)
    {
        int min = int.MaxValue;
        for(int i = 0; i < inputs.Length; i++)
        {
            for(int j = 0; j < inputs[i].Length; j++)
            {
                if (inputs[i][j] < min)
                {
                    min = inputs[i][j];
                }
            }
        }
        return min;

    }
    public static void Main()
    {
        int[][] x;
        int ans;
        Console.WriteLine("How many times should I ask for numbers?");
        int y = int.Parse(Console.ReadLine());
        x = new int[y][];
        for (int i = 0; i < y; i++){
            Console.WriteLine("How many numbers will you enter this time?");
            int z = int.Parse(Console.ReadLine());

            x[i] = new int[z];

            for (int j = 0; j < z; j++)
            {
                Console.WriteLine("What is the " + j + "+th number?");
                x[i][j] = int.Parse(Console.ReadLine());
            }
        }
        ans = search(x);
        Console.WriteLine(ans);



    }
}