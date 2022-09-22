/*using System;
interface test1{
    void add(int a,int b);   // default modifier is public.
}
interface test2{
    void add(int a ,int b);
}

class testing:test2,test1{
    void test1.add(int a,int b){  //declaring interface method  separately for calling the add method separately for each .
        Console.WriteLine(a+b);
    }
    void test2.add(int a,int b){   //declaring interface method  separately for calling the add method separately for each .
        Console.WriteLine(a-b);
    }
    public static void Main(){
        testing t1=new testing();
        test1 it1 = t1;
        it1.add(1, 3);
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateApp
{

    /// <summary>
    /// A class to define a person
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        //Our delegate
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {

            //Create 4 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            Console.Read();
        }

        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }

            Console.Write("\n\n");
        }

        //==========FILTERS===================
        static bool IsChild(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}