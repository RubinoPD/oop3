using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainLoginPage : Form
    {

        //public string username;
        //public string password;
        private List<User> userList;


        
        public MainLoginPage()
        {
            InitializeComponent();


            if (userList == null)
            {
                userList = new List<User>();

                userList.Add(new User("Robertas", "Kaskur", new DateTime(1995, 01, 07), "rob", "admin"));
                userList.Add(new User("User", "User", new DateTime(1997, 02, 16), "user", "user"));
                userList.Add(new User("Donatas", "Don", new DateTime(1996, 10, 17), "don", "don"));
                userList.Add(new User("Mark", "Ma", new DateTime(2006, 06, 06), "mark", "mark"));
                userList.Add(new Admin("admin", "admin", new DateTime(1995-02-10), "admin", "admin"));
            } else
            {
                GetUserList();
            }
            

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(userList);
            registration.Show();
        }

        public List<User> GetUserList()
        {
            return userList;
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {

            bool usernameFound = false;

            string enteredUsername = usernameTxt.Text;
            string enteredPassword = passwordTxt.Text;

            User loggedInUser = CheckedCredentials(enteredUsername, enteredPassword);

            if (loggedInUser != null)
            {
                MessageBox.Show("Prisijungimas sėkmingas!");
                usernameFound = true;
                this.Hide();
                UserInterface userInterface = new UserInterface(loggedInUser, userList, this);
                userInterface.Show();


            }

            if (!usernameFound)
            {
                MessageBox.Show("Toks vartotojas nerastas!");
            }

        }

        private User CheckedCredentials(string enteredUsername, string enteredPassword)
        {
            foreach (User user in userList)
            {
                if (user.Username == enteredUsername && user.Password == enteredPassword)
                {

                    return user;
                }
            }
            return null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
