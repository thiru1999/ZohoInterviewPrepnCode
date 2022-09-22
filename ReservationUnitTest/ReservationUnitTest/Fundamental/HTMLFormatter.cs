using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationUnitTest.Fundamental
{
    public class HTMLFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
