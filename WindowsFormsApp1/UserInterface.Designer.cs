namespace WindowsFormsApp1
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabelTxt = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.imageUploadBtn = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameLabelTxt = new System.Windows.Forms.Label();
            this.surnameLabelTxt = new System.Windows.Forms.Label();
            this.dateLabelTxt = new System.Windows.Forms.Label();
            this.showUsersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabelTxt
            // 
            this.usernameLabelTxt.AutoSize = true;
            this.usernameLabelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelTxt.Location = new System.Drawing.Point(453, 9);
            this.usernameLabelTxt.Name = "usernameLabelTxt";
            this.usernameLabelTxt.Size = new System.Drawing.Size(151, 24);
            this.usernameLabelTxt.TabIndex = 0;
            this.usernameLabelTxt.Text = "Sveiki prisijunge,";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(12, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 30);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Atsijungti";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.Location = new System.Drawing.Point(153, 12);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(188, 30);
            this.changePasswordBtn.TabIndex = 3;
            this.changePasswordBtn.Text = "Keisti slaptažodį";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // imageUploadBtn
            // 
            this.imageUploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageUploadBtn.Location = new System.Drawing.Point(460, 414);
            this.imageUploadBtn.Name = "imageUploadBtn";
            this.imageUploadBtn.Size = new System.Drawing.Size(144, 35);
            this.imageUploadBtn.TabIndex = 4;
            this.imageUploadBtn.Text = "Įkelti profilio nuotrauką";
            this.imageUploadBtn.UseVisualStyleBackColor = true;
            this.imageUploadBtn.Click += new System.EventHandler(this.imageUploadBtn_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(457, 63);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(306, 345);
            this.profilePictureBox.TabIndex = 5;
            this.profilePictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jūsų duomenys:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vardas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pavardė:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gimimo metai:";
            // 
            // nameLabelTxt
            // 
            this.nameLabelTxt.AutoSize = true;
            this.nameLabelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelTxt.Location = new System.Drawing.Point(149, 115);
            this.nameLabelTxt.Name = "nameLabelTxt";
            this.nameLabelTxt.Size = new System.Drawing.Size(65, 24);
            this.nameLabelTxt.TabIndex = 10;
            this.nameLabelTxt.Text = "vardas";
            // 
            // surnameLabelTxt
            // 
            this.surnameLabelTxt.AutoSize = true;
            this.surnameLabelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabelTxt.Location = new System.Drawing.Point(149, 149);
            this.surnameLabelTxt.Name = "surnameLabelTxt";
            this.surnameLabelTxt.Size = new System.Drawing.Size(78, 24);
            this.surnameLabelTxt.TabIndex = 11;
            this.surnameLabelTxt.Text = "pavarde";
            // 
            // dateLabelTxt
            // 
            this.dateLabelTxt.AutoSize = true;
            this.dateLabelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabelTxt.Location = new System.Drawing.Point(149, 185);
            this.dateLabelTxt.Name = "dateLabelTxt";
            this.dateLabelTxt.Size = new System.Drawing.Size(122, 24);
            this.dateLabelTxt.TabIndex = 12;
            this.dateLabelTxt.Text = "gimimo metai";
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Location = new System.Drawing.Point(626, 414);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(137, 35);
            this.showUsersBtn.TabIndex = 13;
            this.showUsersBtn.Text = "Rodyti registruotus naudotojus";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            this.showUsersBtn.Click += new System.EventHandler(this.showUsersBtn_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showUsersBtn);
            this.Controls.Add(this.dateLabelTxt);
            this.Controls.Add(this.surnameLabelTxt);
            this.Controls.Add(this.nameLabelTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.imageUploadBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.usernameLabelTxt);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabelTxt;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button imageUploadBtn;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nameLabelTxt;
        private System.Windows.Forms.Label surnameLabelTxt;
        private System.Windows.Forms.Label dateLabelTxt;
        private System.Windows.Forms.Button showUsersBtn;
    }
}