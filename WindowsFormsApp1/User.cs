using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string ImagePath { get; set; }

        // Constructor

        public User(string name, string surname, DateTime birthDate, string username, string password, bool isAdmin = false, string imagePath = "")
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            ImagePath = imagePath;
        }
    }
}
