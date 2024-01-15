using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class ChangePassword : Form
    {

        private User loggedInUser;
        private List<User> userList;

        // Singleton instance
        
        public ChangePassword(User loggedInUser, List<User> userList)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.userList = userList;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPassTxt.Text;
            string newPassword = newPassTxt.Text;

            // Check if the old password is correct

            if (oldPassword == loggedInUser.Password)
            {
                loggedInUser.Password = newPassword;
                               
                MessageBox.Show("Slaptazodis atnaujintas sekmingai!");
                this.Close();
            } else
            {
                MessageBox.Show("Neteisingas senas slaptazodis!");
            }
        }

    }
}
