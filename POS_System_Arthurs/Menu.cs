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

        double total = 0; //order total
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

        private void updateTotalLabel()
        {
            TOTAL_Label.Text = "$" + total.ToString();
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
        //BURGERS
        private void lucifer_Click(object sender, EventArgs e)
        {
            product2.Text += "\n" + Burger[5].name ;
            ItemPrice2.Text = Burger[5].price.ToString();
            total += Burger[5].price;
            updateTotalLabel();
        }

        private void classicChickPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text += "\n" + Burger[4].name;
            ItemPrice2.Text += "\n" + Burger[4].price.ToString();
            total += Burger[4].price;
            QTY2.Value++;
            updateTotalLabel();
        }

        private void mushroomNswissPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text += "\n" + Burger[1].name;
            ItemPrice2.Text += "\n" + Burger[1].price.ToString();
            total += Burger[1].price;
            QTY2.Value++;
            updateTotalLabel();
        }

        private void arthursBurgerPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text +="\n"+ Burger[0].name;
            ItemPrice2.Text +="\n"+ Burger[0].price.ToString();
            total += Burger[0].price;
            QTY2.Value++;
            updateTotalLabel();
        }

        private void mountMacPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text += "\n" + Burger[2].name;
            ItemPrice2.Text += "\n" + Burger[2].price.ToString();
            QTY2.Value++;
            total += Burger[2].price;
            updateTotalLabel();
        }

        private void pestoPictureBox_Click(object sender, EventArgs e)
        {
            product2.Text += "\n" + Burger[3].name;
            ItemPrice2.Text += "\n" + Burger[3].price.ToString();
            QTY2.Value++;
            total += Burger[3].price;
            updateTotalLabel();
        }

        //DRINKS
        private void softDrinksPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text +="\n"+ Drinks[0].name ;
            ItemPrice4.Text += "\n" + Drinks[0].price.ToString();
            QTY4.Value++;
            total += Drinks[0].price;
            updateTotalLabel();
        }

        private void waterPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[1].name;
            ItemPrice4.Text += "\n" + Drinks[1].price.ToString();
            QTY4.Value++;
            total += Drinks[1].price;
            updateTotalLabel();
        }

        private void sparklingWaterPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[2].name ;
            ItemPrice4.Text += "\n" + Drinks[2].price.ToString();
            QTY4.Value++;
            total += Drinks[2].price;
            updateTotalLabel();
        }

        private void juicePictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[3].name;
            ItemPrice4.Text += "\n" + Drinks[3].price.ToString();
            QTY4.Value++;
            total += Drinks[3].price;
            updateTotalLabel();
        }

        private void redbullPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[4].name;
            ItemPrice4.Text += "\n" + Drinks[4].price.ToString();
            QTY4.Value++;
            total += Drinks[4].price;
            updateTotalLabel();
        }

        //STARTERS
        private void gravyTendersPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[0].name;
            ItemPrice1.Text += "\n" + Starters[0].price.ToString();
            QTY1.Value++;
            total += Starters[0].price;
            updateTotalLabel();
        }

        private void pattyFriesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[1].name;
            ItemPrice1.Text += "\n" + Starters[1].price.ToString();
            QTY1.Value++;
            total += Starters[1].price;
            updateTotalLabel();
        }

        private void dreamyMashedPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[4].name;
            ItemPrice1.Text += "\n" + Starters[4].price.ToString();
            QTY1.Value++;
            total += Starters[4].price;
            updateTotalLabel();
        }

        private void macNcheesePictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n"+Starters[3].name;
            ItemPrice1.Text += "\n" + Starters[3].price.ToString();
            QTY1.Value++;
            total += Starters[3].price;
            updateTotalLabel();
        }

        private void luciferBitesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[2].name;
            ItemPrice1.Text += "\n" + Starters[2].price.ToString();
            QTY1.Value++;
            total += Starters[2].price;
            updateTotalLabel();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        //TOWERS
        private void beefTowerPictureBox_Click_1(object sender, EventArgs e)
        {
            product3.Text += "\n" + Towers[0].name;
            Towers[0].IncreaseQuantity();            
            ItemPrice3.Text = "$" + getTowersPrice();//ItemPrice3.Text += "\n" + Towers[0].price.ToString();
            QTY3.Value++;
            total += Towers[0].price;
            updateTotalLabel();
        }

        private void chickenTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text += "\n" + Towers[1].name ;
            Towers[1].IncreaseQuantity();
            ItemPrice3.Text = "$" + getTowersPrice();//ItemPrice3.Text += "\n" + Towers[1].price.ToString();
            QTY3.Value++;
            total += Towers[1].price;
            updateTotalLabel();
        }

        private void luciferTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text += "\n" + Towers[2].name;
            Towers[2].IncreaseQuantity();
            ItemPrice3.Text = "$" + getTowersPrice();//ItemPrice3.Text += "\n" + Towers[2].price.ToString();
            QTY3.Value++;
            total += Towers[2].price;
            
            updateTotalLabel();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            Reciept Recieptform = new Reciept();
            Recieptform.Show();
        }

        private void QTY1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
        }

        int OldVal3=0;
        //get total price for ordered towers
        private void QTY3_ValueChanged(object sender, EventArgs e)
        {
            if (QTY3.Value > OldVal3)
            {
                ItemPrice3.Text = "$" + getTowersPrice();
                //need to increase the tower quantity... how?
            }
            else
            {
                //how do i know which tower item decrease??
            }
            OldVal3 = ((int)QTY3.Value);
        }

        private string getTowersPrice()
        {
            double price = 0;
            for (int i = 0; i < Towers.Count; i++)
            {
                price += Towers[i].price * Towers[i].getQuantity();
            }
           
            return price.ToString();
        }
        
    }
}
