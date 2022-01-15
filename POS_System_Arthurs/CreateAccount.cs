using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;


namespace POS_System_Arthurs
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            passwordTextbox.Text = "Password";
            userNameTextbox.Text = "User name";
        }


        private void userNameTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (userNameTextbox.Text == "User name")
                userNameTextbox.Text = "";
        }

        private void userNameTextbox_Leave(object sender, EventArgs e)
        {
            if (userNameTextbox.Text == "")
                userNameTextbox.Text = "User name";
        }

        private void passwordTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordTextbox.Text == "Password")
                passwordTextbox.Text = "";
        }

        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "")
                passwordTextbox.Text = "Password";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN mainForm = new LOGIN();
            mainForm.Show();
            
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string user = userNameTextbox.Text;
            string pass = passwordTextbox.Text;

             if (userNameTextbox.Text == "" || userNameTextbox.Text == "User name" )  
            {            
                MessageBox.Show("Please fill in all fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  
                userNameTextbox.Focus();       
            }
             else if (!Regex.Match(userNameTextbox.Text, "^[A-Za-z][A-Za-z]*$").Success || userNameTextbox.Text.IndexOf(" ") > 0)
            {
                MessageBox.Show("--> Can only contain letters \n--> Can't contain spaces ", "Invalid user name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTextbox.Focus();
            }

            else if (passwordTextbox.Text == "" || passwordTextbox.Text == "Password")
            {

                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextbox.Focus(); 
            }

            else if (passwordTextbox.Text.IndexOf(" ") > 0 )
            {
                MessageBox.Show("--> Can't contain spaces ", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTextbox.Focus();
            }

             else
            {
                LOGIN.AddUser(userNameTextbox.Text,passwordTextbox.Text);
                this.Close();
                LOGIN mainForm = new LOGIN();
                mainForm.Show();

            }
           
        }
    }
}
