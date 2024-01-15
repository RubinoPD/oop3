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
    public partial class Registration : Form
    {

        private List<User> userList;


        public Registration(List<User> userList)
        {
            InitializeComponent();
            this.userList = userList;

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {


            DateTime date;

            bool IsOldEnough()
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - date.Year - (currentDate.Month < date.Month || (currentDate.Month == date.Month && currentDate.Day < date.Day) ? 1 : 0);
                return age >= 14;
            }

            if (DateTime.TryParse(dateTxt.Text, out date) && nameTxt.Text != "" && surnameTxt.Text != "" && usernameTxt.Text != "" && passwordTxt.Text != "") {

                if (IsOldEnough() == true)
                {
                    User newUser = new User(nameTxt.Text, surnameTxt.Text, date, usernameTxt.Text, passwordTxt.Text);
                    // Prideti sita newUser i Lista egzistuojanciu useriu.
                    userList.Add(newUser);

                    MessageBox.Show("Registracija sėkminga!");

                    this.Close();
                } else
                {
                    MessageBox.Show("Negali registruotis jaunesni nei 14 metu!");
                }
            } else
            {
                MessageBox.Show("Prašome tvarkingai užpildyti formą!");
            }
            
                
                
            


        }
    }
}
