﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Input;

namespace POS_System_Arthurs
{
    public partial class LOGIN : Form
    {
        SQLiteConnection m_dbConnection;
        List<User> users;

        public LOGIN()
        {
            users = new List<User>();

            InitializeComponent();
            try
            {
                m_dbConnection = new SQLiteConnection("Data Source=users.sqlite; Version=3;");
                m_dbConnection.Open();
                //MessageBox.Show("Connected to Database", "Database Operation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadUsers();

        }

        private void LoadUsers()
        {
            string sql = "select * from account;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // MessageBox.Show("Name: " + reader["username"] + "\tpassword: " + reader["password"]);
                User temp = new User();
                temp.username = reader["username"].ToString();
                temp.password = reader["password"].ToString();
                users.Add(temp);
            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private bool verifyUser()
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(users[i].username== userText.Text && users[i].password== PasswordText.Text)
                {
                    return true;
                }
            }

            return false;

        }
        private void LOGINUSER()
        {
            if (verifyUser())
            {
                this.Hide();
                Menu form = new Menu();
                form.Show();
              //  this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect", "LOGIN FAILED", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LOGINUSER();
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LOGINUSER();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
