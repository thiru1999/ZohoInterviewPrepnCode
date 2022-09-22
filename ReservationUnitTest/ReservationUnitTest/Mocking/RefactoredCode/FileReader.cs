using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReservationUnitTest.Mocking
{
    public interface IfileReader
    {
        string Read(string Path);
    }
    public class FileReader : IfileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
         
        }
    }
}
