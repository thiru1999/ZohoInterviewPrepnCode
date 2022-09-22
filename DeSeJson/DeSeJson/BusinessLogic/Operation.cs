using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeSeJson
{
    public class Operation : IOperation
    {


        public void Adding(Employee e)
        {
            Program.emplist.Add(e);
            Program.k = JsonConvert.SerializeObject(Program.emplist);
            File.WriteAllText(@"C:\Users\Z004K1SD\source\repos\DeSeJson\DeSeJson\bin\Debug\DeSe.Json",Program.k);
        }

        public void Deleting(string name)
        {
            String l = Program.k.Replace('"', '\"');
            List<Employee> empList = JsonConvert.DeserializeObject<List<Employee>>(l);
            //foreach (Employee e in empList.ToList()) // DFOubt
            //{
            //    if (e.Name==name)
            //    {
            //        empList.Remove(e);
            //    }
            //}
            empList.RemoveAll(s => s.Name == name);
            Program.k= JsonConvert.SerializeObject(empList);
            File.WriteAllText(@"C:\Users\Z004K1SD\source\repos\DeSeJson\DeSeJson\bin\Debug\DeSe.Json", Program.k);
        }
        public void Updating(string editedName, string nameToChange)
        {
            String l = Program.k.Replace('"','\"');
            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(l) ;

            //foreach(Employee i in emp)
            //{
            //    if (i.Name == nameToChange)
            //    {
            //        i.Name = editedName;
            //    }

            //}
            emp.Where(obj => obj.Name == nameToChange).Select(obj => { obj.Name=editedName; return obj; }).ToList();
            Program.k = JsonConvert.SerializeObject(emp);
            File.WriteAllText(@"C:\Users\Z004K1SD\source\repos\DeSeJson\DeSeJson\bin\Debug\DeSe.Json", Program.k);

        }
    }
}
