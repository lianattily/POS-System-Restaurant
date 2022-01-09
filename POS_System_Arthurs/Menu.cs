using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace POS_System_Arthurs
{
    public partial class Menu : Form
    {
        List<Item> MENU=new List<Item>();
        SQLiteConnection m_dbConnection;
        public Menu()
        {
            InitializeComponent();

            try
            {
                m_dbConnection = new SQLiteConnection("Data source=Menu.sqlite; Version=3;");
                m_dbConnection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            loadMenu();
        }

        //Load menu from database to labels
        private void loadMenu()
        {
            string sql = "select * from burgers;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Item i=new Item();
                i.ID = int.Parse(reader["BID"].ToString());
                i.price=double.Parse(reader["Price"].ToString());
                i.name=reader["ItemName"].ToString();
                i.description = reader["Description"].ToString();
                MENU.Add(i);
            }

        }

        private void customOrder_Click(object sender, EventArgs e)
        {
            CustomOrder CustomOrderForm = new CustomOrder();
            CustomOrderForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {

        }
    }
}
