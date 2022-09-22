//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp15
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            Program1 pg1 = new Program1();
//            pg1.check();



//        }
//    }

//    public class Program1
//    {

//        public void check()
//        {
//            Program1 p = new Program1();
//            Console.WriteLine( this.Equals(p));


//        }
//    }
//}

//using System;
//using System.Text.RegularExpressions;

//public class Test
//{
//    public static void Main()
//    {
//        // Define a regular expression for repeated words.
//        Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
//          RegexOptions.Compiled | RegexOptions.IgnoreCase);

//        // Define a test string.
//        string text = "The the quick brown fox  fox jumps over the lazy dog dog.";

//        // Find matches.
//        MatchCollection matches = rx.Matches(text);

//        // Report the number of matches found.
//        Console.WriteLine("{0} matches found in:\n   {1}",
//                          matches.Count,
//                          text);

//        // Report on each match.
//        foreach (Match match in matches)
//        {
//            GroupCollection groups = match.Groups;
//            Console.WriteLine("'{0}' repeated at positions {1} and {2}",
//                              groups["word"].Value,
//                              groups[0].Index,
//                              groups[1].Index);
//        }
//    }
//}

// The example produces the following output to the console:
//       3 matches found in:
//          The the quick brown fox  fox jumps over the lazy dog dog.
//       'The' repeated at positions 0 and 4
//       'fox' repeated at positions 20 and 25
//       'dog' repeated at positions 49 and 53


using System;
public class ArrayExample
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];//creating array  
        arr[0] = 10;//initializing array  
        arr[2] = 20;
        arr[4] = 30;
        Console.WriteLine(arr.GetLength(0));

        //traversing array  
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}