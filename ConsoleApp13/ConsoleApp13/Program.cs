






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp13
{
    internal class Program
    {
        public static void Main()
        {
            var xmlData = @"<?xml version=""1.0"" encoding=""UTF-8""?>
            <words>
            <word>falcon</word>
            <word>sky</word>
            <word>bottom</word>
            <word>cup</word>
            <word>book</word>
            <word>rock</word>
            <word>sand</word>
            <word>river</word>
            </words>
            ";

            var doc = new XmlDocument();
            doc.LoadXml(xmlData);

            Console.WriteLine(doc.DocumentElement?.Name);
            Console.WriteLine(doc.DocumentElement?.FirstChild?.InnerText);
            Console.WriteLine(doc.DocumentElement?.LastChild?.InnerText);
            Console.WriteLine(doc.DocumentElement?.OuterXml);
            Console.WriteLine(doc.DocumentElement?.InnerXml);

        }


    }
}
