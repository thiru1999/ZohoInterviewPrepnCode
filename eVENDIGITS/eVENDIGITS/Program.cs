using System;

public class Solution
{
    public static int FindNumbers(string[] nums)
    {
        int count = 0;
        foreach (string s in nums)
        {
            int length = s.Length;
            if (length % 2 == 0)
            {
                count++;
            }
        }
        return count;

    }
    public static void Main()
    {
        int ans;
        string[] input = Console.ReadLine().Split(',');
        ans = FindNumbers(input);
        Console.WriteLine(ans);
    }
}