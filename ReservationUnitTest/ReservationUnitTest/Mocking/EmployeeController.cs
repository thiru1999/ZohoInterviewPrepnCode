using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ReservationUnitTest.Mocking.RefactoredCode;
using System.Data.Entity;

namespace ReservationUnitTest.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage _storage;
        public EmployeeController(IEmployeeStorage storage)
        {
            _storage = storage;

        }
        

        public ActionResult DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);
           
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }

    public class RedirectResult : ActionResult { }

    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }

}
