using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace EmployeeMgmtDese
{
    internal class Program
    {
        private static List<Employee> emplist = new List<Employee>();
        public static List<Employee> Emplist
        {
            get
            {
                return emplist;
            }
            set
            {
                emplist = value;
            }
        }

        public static void AdditionExecution(IOperation op)
        {
            op.Adding();
        }
        public static void DeletionExecution(IOperation op)
        {
            op.Deleting("Shree");
        }
        public static void UpdationExecution(IOperation op)
        {
            op.Updating("Serma", "Mani");
        }
        static void Main()
        {

            Emplist =new List<Employee>() { new Employee("Thiru","Male",22),new Employee("Mani","Male",23),
            new Employee("Kumar","Male",24),new Employee("Shree","Female",23)};
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            using (Stream stream = File.Open("EmployeeDataBase.xml", FileMode.Create))
            {
                serializer.Serialize(stream,Emplist);
            }
            Program.AdditionExecution(new Operation());
            Program.UpdationExecution(new Operation());
            Program.DeletionExecution(new Operation());
            /*op.Adding();
            op.Updating("Serma","Mani");
            op.Deleting("Shree");*/
        }
    }
}
