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
    public partial class CustomOrder : Form
    {
        SQLiteConnection m_dbConnection;
        Item burger;
        public CustomOrder()
        {
            burger = new Item();
            InitializeComponent();
            try
            {
                m_dbConnection = new SQLiteConnection("Data Source=menu.sqlite; Version=3;");
                m_dbConnection.Open();

            }catch(Exception ex)
            {
                MessageBox.Show($"EXCEPTION: {ex.GetType().ToString()}", "COULD NOT CONNECT TO DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LOADBURGERS();
        }

        private void LOADBURGERS()
        {
            string sql = "SELECT * FROM BURGERS";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                burger.ID = int.Parse(reader["BID"].ToString());
            }
        }

        private void CustomOrder_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = $"insert into BURGERS (ItemName, Price) values ('{MeatComboBox.SelectedItem.ToString()}',5.8);";
                string sql = $"insert into BURGERS(ItemName, Price) values ('{MeatComboBox.SelectedItem.ToString()}',5)";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"EXCEPTION: {ex.GetType().ToString()}", "COULD NOT ADD CUSTOM ORDER TO DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
