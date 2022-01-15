using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
