using System;
class Solution
{
    static void Main(String[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        for(int I = 0; I < n; I++)
        {
            Console.WriteLine(new String('#',I+1).PadLeft(n,' '));
        }

    }
}