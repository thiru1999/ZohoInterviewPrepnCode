using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMosh
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resize photo");
        }
    }
}
