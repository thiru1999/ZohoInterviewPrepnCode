using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXER
{
    public class program1
    {
        private int _salary, _eno;
        public  program1(int salary,int eno)
        {
            _salary = salary;
            _eno = eno;


        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return _salary;
                }
                else if(index==1){
                    return _eno;

                }
                return null;
            }

        }
       /*
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        public int eno
        {
            get
            {
                return _eno;
            }
            set
            {
                _eno = value;
            }
        }*/

    }
    public class Program
    {

        static void Main(string[] args)
        {
            program1 p1 = new program1(100,101);
            /*p1.Salary = 20000;
            p1.eno = 102;*/
            Console.WriteLine(p1[0]);
            
        }
    }
}
