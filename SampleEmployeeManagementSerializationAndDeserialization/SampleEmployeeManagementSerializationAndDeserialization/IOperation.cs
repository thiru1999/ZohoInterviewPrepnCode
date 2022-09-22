using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEmployeeManagementSerializationAndDeserialization
{
    public interface IOperation
    {
        void Updating(string name);
        void Deleting(string name);
        void Adding();
    }
}
