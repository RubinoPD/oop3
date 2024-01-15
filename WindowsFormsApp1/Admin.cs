using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Admin : User
    {

        public Admin(string name, string surname, DateTime birthDate, string username, string password) : base(name, surname, birthDate, username, password, true)
        {
            
        }

    }
}
