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
        List<Item> Burger=new List<Item>();
        List<Item> Drinks = new List<Item>();
        List<Item> Starters = new List<Item>();
        List<Item> Towers = new List<Item>();
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

            loadBurger();
            loadDrinks();
            loadStarters();
            loadTowers();
        }

        //Load menu from database to labels
        private void loadBurger()
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
                Burger.Add(i);
            }

            

        }

        private void loadDrinks()
        {
            string sql = "select * from drinks;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Item i = new Item();
            
                i.price = double.Parse(reader["Price"].ToString());
                i.name = reader["ItemName"].ToString();
                
                Drinks.Add(i);
            }



        }

        private void loadStarters()
        {
            string sql = "select * from starters;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Item i = new Item();
                
                i.price = double.Parse(reader["Price"].ToString());
                i.name = reader["ItemName"].ToString();
                i.description = reader["Description"].ToString();
                Starters.Add(i);
            }



        }

        private void loadTowers()
        {
            string sql = "select * from towers;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Item i = new Item();

                i.price = double.Parse(reader["Price"].ToString());
                i.name = reader["ItemName"].ToString();
                i.description = reader["Description"].ToString();
                Towers.Add(i);
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

        

        private void classicChicklabel_Click(object sender, EventArgs e)
        {

        }

        private void arthursburger_Click(object sender, EventArgs e)
        {

        }

        private void classicChick_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lucifer_Click(object sender, EventArgs e)
        {
            product1.Text = Burger[6].name + Burger[6].price;
        }

        private void classicChickPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Burger[5].name + Burger[5].price;
        }

        private void mushroomNswissPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text = Burger[2].name + Burger[2].price;
        }

        private void arthursBurgerPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text = Burger[2].name + Burger[2].price;
        }

        private void mountMacPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text = Burger[3].name + Burger[3].price;
        }

        private void pestoPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text = Burger[4].name + Burger[4].price;
        }

        private void softDrinksPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text = Drinks[1].name + Drinks[1].price;
        }

        private void waterPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text = Drinks[2].name + Drinks[2].price;
        }

        private void sparklingWaterPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text = Drinks[3].name + Drinks[3].price;
        }

        private void juicePictureBox_Click(object sender, EventArgs e)
        {
            product4.Text = Drinks[4].name + Drinks[4].price;
        }

        private void redbullPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text = Drinks[5].name + Drinks[5].price;
        }

        private void gravyTendersPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Starters[1].name + Starters[1].price;
        }

        private void pattyFriesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Starters[2].name + Starters[2].price;
        }

        private void dreamyMashedPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Starters[3].name + Starters[3].price;
        }

        private void macNcheesePictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Starters[4].name + Starters[4].price;
        }

        private void luciferBitesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text = Starters[5].name + Starters[5].price;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void beefTowerPictureBox_Click_1(object sender, EventArgs e)
        {
            product3.Text = Towers[1].name + Towers[1].price;
        }

        private void chickenTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text = Towers[2].name + Towers[2].price;
        }

        private void luciferTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text = Towers[3].name + Towers[3].price;
        }
    }
}
