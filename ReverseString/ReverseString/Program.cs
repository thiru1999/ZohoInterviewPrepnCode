using System;
using System.Text;
class ReverseWord
{
    public static string ReverseString(string s)
    {
        StringBuilder reversed = new StringBuilder(s.Length);
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }
        for(int i = s.Length-1; i >= 0; i--)
        {
            reversed.Append(s[i]);
        }
        return reversed.ToString();
    }
    public static string ReverseStringArray(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
       
    }
    public static void Main()
    {
        Console.WriteLine(ReverseStringArray("Hello World"));
        Console.WriteLine(ReverseString("Hello World"));
        Console.WriteLine(ReverseString(" "));

    }

}