using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndHashSet
{
    internal class Program
    {
        public class Employee
        {
            public string Name
            {
                get;set;
            }
            public int Id
            {
                get;set;
            }
        }
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int, Employee> RepoOfEmployee = new Dictionary<int, Employee>();
            RepoOfEmployee.Add(1, new Employee() { Id = 2, Name = "Kumar" });
            RepoOfEmployee.Add(2, new Employee() { Id = 2, Name = "Mani" });
            Employee e;
            RepoOfEmployee.TryGetValue(1, out e);
            Console.WriteLine(e.Name);

            HashSet<string> id = new HashSet<string>();
            id.Add("kumar");
            id.Add("mani");
            Console.WriteLine( id.Contains("kumar"));
        }

    }
}
