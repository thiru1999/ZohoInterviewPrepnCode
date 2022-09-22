/*using System;
class Hackerrank_bigarray
{
    public static void Main()
    {
        int n;
        string val;
        long total = 0;
        Console.WriteLine("enter the size");
        val = Console.ReadLine();
        n = Convert.ToInt32(val);
        long[] array = new long[25];
        Console.WriteLine("enter the value");
        array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt64);  //take array as input using the split function (space),int64 means changing to double
        for (int i = 0; i < n; i++)
        {


            total = total + array[i];

        }
        Console.WriteLine(total);
    }
}*/

using System;

/*public class StringExample
{
    public static void Main()
    {
        var i = 10;
        i = i + 10;
        object ob = "jskdnk";
        ob = ob + "kbjbjb";
        Console.WriteLine(ob);
        Console.WriteLine(i);
       

    }
    
}
*/


public class explicit_checking
{
    public static void Main()
    {
        int i = 10;
        char s = '5';
        i = s;
        Console.WriteLine(i);




    }
}