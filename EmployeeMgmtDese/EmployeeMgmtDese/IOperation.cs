using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtDese
{
    internal interface IOperation
    {
        void Adding();
        void Deleting(string name);
        void Updating(string name,string name1);

    }
}
