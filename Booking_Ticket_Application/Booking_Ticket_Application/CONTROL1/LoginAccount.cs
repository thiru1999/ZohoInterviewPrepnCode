using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicketApplication
{
    public class LoginAccount
    {
        string username, password;
        private Dictionary<string, string> credentialDetails = new Dictionary<string, string>{ { "kumar", "Veeramani@199" },{ "THir", "1707" } };

        public LoginAccount(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public int Checking()
        {
            try
            {
                if (!(credentialDetails.ContainsKey( username) ))
                {
                    throw new Exception("Invalid Username or Password, Pls Check again and type");

                }
                if (password != credentialDetails[username])
                {
                    throw new Exception("Invalid Username or Password, Pls Check again and type");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            if (password == credentialDetails[username])
            {
                Console.WriteLine("Logged In Successfully");
                Console.WriteLine($"Welcome {username}");
                return 1;
            }
            return 0;

        }

    }
}
