using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////https://github.com/DDLibaneo/Advanced-Csharp-Mosh/blob/master/LambdaExpressions/Program.cs
//No access Modifier 
//No name
//No return Statement

namespace LambdaExpressionMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The syntax for lambda works like this: arguments => expression
            // Read that as in: 'arguments goes to expression'
            // Example: number => number * number
            // To use a lambda function we assign it to a delegate, like below
            // more examples:
            // without args: () => ...
            // with only 1 arg: x => ...
            // with multiple args: (x, y, z)
            Func<int, int> square = (number) => number * number;
            Console.WriteLine(square(5));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll((book) => book.Price < 10);
            foreach(Book b in cheapBooks)
            {
                Console.WriteLine(b.Title);

            }

        }
    }
}
