using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSeJson
{
    internal interface IOperation
    {
        void Adding(Employee e);
        void Deleting(string name);
        void Updating(string name, string name1);

    }
}
