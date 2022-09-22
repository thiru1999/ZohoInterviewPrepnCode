using System;
using System.Text;

class ReverseEachWord
{
    public static string Reverse(string s)
    {
        StringBuilder s2 = new StringBuilder();
        StringBuilder s3 = new StringBuilder();
        foreach(char i in s)
        {
            s2.Append(i);
            if (i==' ' )   //Best to use Split() function in order to segregate the Array
            {
                for (int j = s2.Length - 1; j >= 0; j--)
                {
                    s3.Append(s2[j]);
                }
                s2.Clear();
            }
        }
        return s3.ToString();


    }
    public static void Main()
    {
        Console.WriteLine(Reverse("Hello My Name is Kumar "));
        Console.WriteLine(Reverse("Taylor Is a Great Worker SDGERGHERG"));

    }
}