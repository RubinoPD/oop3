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
    public partial class Registruoti_naudotojai : Form
    {

        private List<User> userList;
        public Registruoti_naudotojai(List<User> userList)
        {
            InitializeComponent();
            this.userList = userList;

            // Populate the ListBox with user information
            foreach (User user in userList) 
            {
                listBox1.Items.Add($"{user.Name} {user.Surname} - {user.Username}");
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox1.SelectedIndex != -1)
            {
                // Extract the selected users information from the ListBox
                string selectedUserString = listBox1.SelectedItem.ToString();
                string[] userInfo = selectedUserString.Split('-');

                // Extract the username from the selected users information
                string usernameToRemove = userInfo[1].Trim();

                // Find user in the List by the username
                User userToRemove = userList.Find(x => x.Username == usernameToRemove);

                if (userToRemove != null) 
                { 
                    // Remove the user from the list
                    userList.Remove(userToRemove);

                    // Update the ListBox
                    RefreshUserList();

                    MessageBox.Show($"User {userToRemove.Name} {userToRemove.Surname} has been removed.");
                } else
                {
                    MessageBox.Show("User has not been found!");
                }
            } else
            {
                MessageBox.Show("Please select a user to remove!");
            }
        }

        private void RefreshUserList()
        {
            // Clear and repopulate the ListBox with updated user information.

            listBox1.Items.Clear();

            foreach (User user in userList)
            {
                listBox1.Items.Add ($"{user.Name} {user.Surname} - {user.Username}");
            }
        }

    }
}
