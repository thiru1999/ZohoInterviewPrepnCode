using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icomparer_icomparable
{
    public class student : IComparable<student>  // redesign the sorting function using comparable interface 
    {
        public int id { get; set; } 
      
        public string name { get; set; }
        public int marks { get; set; }

        public int CompareTo(student other)
        {
            if (this.id > other.id)
            {
                return -1;

            }
            else if (this.id<other.id)
            {
                return -1;

            }
            else
            {
                return 0;
            }
        }
    }

    public class sortingfromexternallibrary : IComparer<student>
    {
        public int Compare(student x, student y)
        {
            if (x.marks > y.marks)
            {
                return 1;
            }
            else if (x.marks < y.marks)
            {
                return -1;

            }
            else
            {
                return 0;
            }
            
        }
    }

    public class student_test
    {
        public static void Main()
        {
            student s1 = new student() { id=300,name="TMK",marks=483};
            student s2 = new student() { id = 100, name = "muru", marks = 485 };
            student s3 = new student() { id = 50, name = "kumar", marks = 1054 };
            List<student> l1 = new List<student>() { s1, s2, s3 };
            sortingfromexternallibrary sfl = new sortingfromexternallibrary();
            l1.Sort(sfl);
            foreach(student obj in l1)
            {
                Console.WriteLine(obj.id + " " + obj.name + " " + obj.marks);
            }


        }

        
    }
    
}
