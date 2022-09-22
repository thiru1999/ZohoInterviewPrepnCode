using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationUnitTest.Fundamental
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            // null
            // ""
            // " "
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
