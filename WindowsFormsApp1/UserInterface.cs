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
    public partial class UserInterface : Form
    {

        private User loggedInUser;
        private List<User> userList;
        private MainLoginPage loginPage;

        public UserInterface(User loggedInUser, List<User> userList, MainLoginPage loginPage)
        {
            InitializeComponent();

            this.userList = userList;
            this.loggedInUser = loggedInUser;
            this.loginPage = loginPage;

            this.usernameLabelTxt.Text = $"Sveiki prisijunge, {loggedInUser.Username}";
            this.nameLabelTxt.Text = loggedInUser.Name;
            this.surnameLabelTxt.Text = loggedInUser.Surname;
            this.dateLabelTxt.Text = loggedInUser.BirthDate.ToString();
            

            if (loggedInUser.IsAdmin == true)
            {
                showUsersBtn.Enabled = true;
                showUsersBtn.Visible = true;
            } else
            {
                showUsersBtn.Enabled = false;
                showUsersBtn.Visible = false;
            }

            loadUserImage();
        }

        private void imageUploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display selected image in the Picture box
                    string selectedImagePath = openFileDialog.FileName;
                    this.profilePictureBox.ImageLocation = selectedImagePath;

                    this.profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    loggedInUser.ImagePath = selectedImagePath;
                }
            }
        }

        private void loadUserImage()
        {
            // Check if the logged-in user has an associated image
            if (!string.IsNullOrEmpty(loggedInUser.ImagePath))
            {
                try
                {
                    // Load the users image and set it to a PictureBox 
                    profilePictureBox.Image = System.Drawing.Image.FromFile(loggedInUser.ImagePath);
                    this.profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                } catch (Exception ex) 
                {
                    MessageBox.Show($"Error loading user image: {ex.Message}");
                }
            } else
            {
                profilePictureBox.Image = null;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage.Show();
            
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(loggedInUser, userList);
            changePassword.Show();
        }

        private void showUsersBtn_Click(object sender, EventArgs e)
        {
            Registruoti_naudotojai usersList = new Registruoti_naudotojai(userList);
            usersList.Show();
        }
    }
}
