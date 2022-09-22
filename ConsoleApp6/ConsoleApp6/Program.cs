using System;
using System.Globalization;

namespace Usingcsharp
{
    class Program
    {
        /* How to Capitalize a First letter of Each word in a string in C# */
        static void Main(string[] args)
        {
            Console.Write("Enter The String Need to be Capitalized: ");

            string str = Console.ReadLine();
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            //Print The Result
            Console.WriteLine("Capitalized String: " + titleCase);

            //Hit ENTER to exit the program
            Console.ReadKey();
        }
    }
}