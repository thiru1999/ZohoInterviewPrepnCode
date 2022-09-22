using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USERDEFINED_COLLECTION
{
    public class USERDEFINED_COLLECTION
    {
        public string Name { get; set; }
        public int Eno { get; set; }
        public int Salary { get; set; }


        
    }
    public class userdefine_collection_test:USERDEFINED_COLLECTION
    {
        public static void Main()
        {
            userdefine_collection_test test = new userdefine_collection_test();
            userdefine_collection_test test1 = new userdefine_collection_test();
            List<userdefine_collection_test> l1 = new List<userdefine_collection_test>();
            test.Name = "kumar ";
            test.Salary = 20000;
            test.Eno = 100;
            l1.Add(test);
            test1.Name = "TMK ";
            test1.Salary = 30000;
            test1.Eno = 200;
            l1.Add(test1);
            foreach(userdefine_collection_test obj in l1)
            {
                Console.WriteLine(obj.Eno+" "+obj.Name+" "+obj.Salary);
            }




        }
    }
}
