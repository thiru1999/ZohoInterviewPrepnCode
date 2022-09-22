/*using System;
using Examples;

namespace Examples
{
    public class Object1
    {
    }
}

public class Example
{
    public static void Main()
    {
        object obj1 = new Object1();
        Console.WriteLine(obj1.ToString());
    }
}
// The example displays the following output:
//   Examples.Object1*/

using System;

public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        int a = 123;
        string s2 = s1.ToString();
        string s3 = a.ToString();
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s3);
    }
}