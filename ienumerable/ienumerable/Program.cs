using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ienumerable
{
    public class employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

    }

    public class organisation:IEnumerable
    {
        List<employee> l1 = new List<employee>();
        public void Add(employee emp)
        {
            l1.Add(emp);

        }
        public int count
        {
            get
            {
                return l1.Count;
            }
        }
        public employee this[int index]
        {
            get
            {
                return l1[index];
            }
        }

        public IEnumerator GetEnumerator()
        {

            return new organisationenumerator(this);
        }
    }

    public class organisationenumerator : IEnumerator
    {
        organisation orgcollection;
        int currindex;
        employee curremp;

        public organisationenumerator(organisation org)
        {
            orgcollection = org;
            currindex = -1;

        }


        public object Current
        {
            get
            {
                return curremp;
            }
        }

        public bool MoveNext()
        {
            if(++currindex >= orgcollection.count)
            {
                return false;

            }
            else
            {
                curremp= orgcollection[currindex];


            }
            return true;
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1=new employee()
            {
                Id = 1,
                name="TMK",
                salary=200000
            };
            employee e2 = new employee()
            {
                Id = 1,
                name = "TMK2",
                salary = 200000000000000
            };
            organisation l1 = new organisation();
            l1.Add(e1);
            l1.Add(e2);
            foreach (employee e in l1)
            {
                Console.WriteLine(e.Id + " " + e.name + " " + e.salary);
            }


        }
    }
}
