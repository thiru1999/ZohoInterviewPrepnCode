﻿//using System;
//using System.Collections.Generic;

//namespace CastingInterfaces
//{
//    interface IStorable
//    {
//        void Save();
//        void Load();
//        bool NeedsSave { get; set; }
//    }

//    class Document : IStorable
//    {
//        private string name;

//        public Document(string s)
//        {
//            name = s;
//            Console.WriteLine("Created a document with name '{0}'", s);
//        }

//        public void Save()
//        {
//            Console.WriteLine("Saving the document");
//        }

//        public void Load()
//        {
//            Console.WriteLine("Loading the document");
//        }

//        public bool NeedsSave
//        {
//            get; set;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Document d = new Document("Test Document");

//            // Use the 'is' operator
//            if (d is IStorable)
//            {
//                d.Save();
//            }

//            // Use the 'as' operator
//            IStorable istor = d as IStorable;
//            if (istor != null)
//            {
//                istor.Load();
//                int i=0;
//                int k = 0;
//                Console.WriteLine(k.GetType()==i.GetType());
//            }

//            Console.WriteLine("\nPress Enter to continue...");
//            Console.ReadLine();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples
{
    class Program
    {
        #region Class Definitions
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string State { get; set; }
            public double Price { get; set; }
            public string[] Purchases { get; set; }
        }

        public class Distributor
        {
            public string Name { get; set; }
            public string State { get; set; }
        }

        public class CustDist
        {
            public string custName { get; set; }
            public string distName { get; set; }
        }

        public class CustDistGroup
        {
            public string custName { get; set; }
            public IEnumerable<string> distName { get; set; }
        }
        #endregion

        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}}
        };

        static List<Distributor> distributors = new List<Distributor>
        {
            new Distributor {Name = "Edgepulse", State = "UT"},
            new Distributor {Name = "Jabbersphere", State = "GA"},
            new Distributor {Name = "Quaxo", State = "FL"},
            new Distributor {Name = "Yakijo", State = "OR"},
            new Distributor {Name = "Scaboo", State = "GA"},
            new Distributor {Name = "Innojam", State = "WA"},
            new Distributor {Name = "Edgetag", State = "WA"},
            new Distributor {Name = "Leexo", State = "HI"},
            new Distributor {Name = "Abata", State = "OR"},
            new Distributor {Name = "Vidoo", State = "TX"}
        };

        static double[] exchange = { 0.89, 0.65, 120.29 };
        #endregion

        static void Main(string[] args)
        {
            var matchupquery =
                from c in customers
                join d in distributors on c.State equals d.State into matches
                select new
                {
                    custname = c.Last,
                    distname = matches.Select(dist => dist.Name)
                };

            foreach (var cd in matchupquery)
            {
                Console.WriteLine("{0}", cd.custname);
                foreach (var d in cd.distname)
                {
                    Console.WriteLine("  {0}", d);
                }
            }
            Console.ReadKey();
        }
    }
}
