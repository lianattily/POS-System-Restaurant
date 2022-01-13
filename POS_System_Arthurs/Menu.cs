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
        List<Item> Burger = new List<Item>();
        List<Item> Drinks = new List<Item>();
        List<Item> Starters = new List<Item>();
        List<Item> Towers = new List<Item>();
        List<Item> allItems = new List<Item>();
        SQLiteConnection m_dbConnection;

        double total = 0; //order total
        public Menu()
        {
            InitializeComponent();
            //   this.ControlBox = false;
            //   this.Text = String.Empty;
           // HIDEBUTTONS();
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
        private void HIDEBUTTONS()
        {
            ArthursBurgeraddBtn.Hide();
            ArthursBurgerMinusBtn.Hide();
            MountMacaddBtn.Hide();
            MountMacMinusBtn.Hide();
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
                Item i = new Item();
                i.ID = int.Parse(reader["BID"].ToString());
                i.price = double.Parse(reader["Price"].ToString());
                i.name = reader["ItemName"].ToString();
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
       
        private void classicChicklabel_Click(object sender, EventArgs e)
        {

        }

        private void arthursburger_Click(object sender, EventArgs e)
        {

        }

        private void classicChick_Click(object sender, EventArgs e)
        {

        }

        private void updateBurgers(int i, string name)
        {
            if(product2.Text.Contains("name")!=true)
                product2.Text += "\n" + Burger[i].name;
            ItemPrice2.Text = Burger[i].price.ToString();
            total += Burger[i].price;
            allItems.Add(Burger[i]);
            updateTotalLabel();
        }
        //BURGERS
        private void lucifer_Click(object sender, EventArgs e)
        {
            updateBurgers(5,"LUCIFER");
        }

        private void classicChickPictureBox_Click(object sender, EventArgs e)
        {
            updateBurgers(4,"CLASSIC CHICK");
        }

        private void mushroomNswissPictureBox_Click(object sender, EventArgs e)
        {
            updateBurgers(1, "MUSHROOM 'N' SWISS");
        }

        private void arthursBurgerPictureBox_Click(object sender, EventArgs e)
        {
            ArthursBurgeraddBtn.Show();
            ArthursBurgerMinusBtn.Show();
            updateBurgers(0, "ARTHUR'S BURGER");
        
        //arthursBurgerPictureBox.Enabled = false;
        }

        private void mountMacPictureBox_Click(object sender, EventArgs e)
        {

            updateBurgers(2, "MOUNT MAC");
        }

        private void pestoPictureBox_Click(object sender, EventArgs e)
        {

            updateBurgers(3, "PESTO BASIL");
        }


        private void updateDrinks(int i, string name)
        {
            if (product4.Text.Contains(name) != true)
                product4.Text += "\n" + Burger[i].name;
            ItemPrice4.Text = Burger[i].price.ToString();
            total += Burger[i].price;
            allItems.Add(Drinks[i]);
            QTY4.Value++;
            updateTotalLabel();
        }
        //DRINKS
        private void softDrinksPictureBox_Click(object sender, EventArgs e)
        {
            updateDrinks(0, "SOFT DRINKS");
            
        }

        private void waterPictureBox_Click(object sender, EventArgs e)
        {
            updateDrinks(1, "WATER");
        }

        private void sparklingWaterPictureBox_Click(object sender, EventArgs e)
        {
            updateDrinks(2, "SPARKLING WATER");
        }

        private void juicePictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[3].name;
            ItemPrice4.Text += "\n" + Drinks[3].price.ToString();
            QTY4.Value++;
            total += Drinks[3].price;
            allItems.Add(Drinks[3]);
            updateTotalLabel();
        }

        private void redbullPictureBox_Click(object sender, EventArgs e)
        {
            product4.Text += "\n" + Drinks[4].name;
            ItemPrice4.Text += "\n" + Drinks[4].price.ToString();
            QTY4.Value++;
            total += Drinks[4].price;
            allItems.Add(Drinks[4]);
            updateTotalLabel();
        }

        //STARTERS
        private void gravyTendersPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[0].name;
            ItemPrice1.Text += "\n" + Starters[0].price.ToString();
            QTY1.Value++;
            total += Starters[0].price;
            allItems.Add(Starters[0]);
            updateTotalLabel();
        }

        private void pattyFriesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[1].name;
            ItemPrice1.Text += "\n" + Starters[1].price.ToString();
            QTY1.Value++;
            total += Starters[1].price;
            allItems.Add(Starters[1]);
            updateTotalLabel();
        }

        private void dreamyMashedPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[4].name;
            ItemPrice1.Text += "\n" + Starters[4].price.ToString();
            QTY1.Value++;
            total += Starters[4].price;
            allItems.Add(Starters[4]);
            updateTotalLabel();
        }

        private void macNcheesePictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[3].name;
            ItemPrice1.Text += "\n" + Starters[3].price.ToString();
            QTY1.Value++;
            total += Starters[3].price;
            allItems.Add(Starters[3]);
            updateTotalLabel();
        }

        private void luciferBitesPictureBox_Click(object sender, EventArgs e)
        {
            product1.Text += "\n" + Starters[2].name;
            ItemPrice1.Text += "\n" + Starters[2].price.ToString();
            QTY1.Value++;
            total += Starters[2].price;
            allItems.Add(Starters[2]);
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
            allItems.Add(Towers[0]);
            updateTotalLabel();
        }

        private void chickenTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text += "\n" + Towers[1].name;
            Towers[1].IncreaseQuantity();
            ItemPrice3.Text = "$" + getTowersPrice();//ItemPrice3.Text += "\n" + Towers[1].price.ToString();
            QTY3.Value++;
            total += Towers[1].price;
            allItems.Add(Towers[1]);
            updateTotalLabel();
        }

        private void luciferTowerPictureBox_Click(object sender, EventArgs e)
        {
            product3.Text += "\n" + Towers[2].name;
            Towers[2].IncreaseQuantity();
            ItemPrice3.Text = "$" + getTowersPrice();//ItemPrice3.Text += "\n" + Towers[2].price.ToString();
            QTY3.Value++;
            total += Towers[2].price;
            allItems.Add(Towers[2]);
            updateTotalLabel();
        }

        Order order;
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            //CREATE ORDER
            order = new Order(allItems);
            Reciept Recieptform = new Reciept(order);
            Recieptform.Show();
        }

        private void QTY1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            product1.Text = " ";
            product2.Text = " ";
            product3.Text = " ";
            product4.Text = " ";
            ItemPrice1.Text = "$";
            ItemPrice2.Text = "$";
            ItemPrice3.Text = "$";
            ItemPrice4.Text = "$";
            QTY1.Value = 0;
            QTY2.Value = 0;
            QTY3.Value = 0;
            QTY4.Value = 0;
            TOTAL_Label.Text = "$";
        }

        int OldVal3 = 0;
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

        private void LOGOUT_BTN_Click(object sender, EventArgs e)
        {

        }

        private void ArthursBurgeraddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(0);

        }

        private double getBurgersPrice()
        {
            double sum = 0;
            for(int i = 0; i < Burger.Count; i++)
            {
                if (Burger[i].getQuantity() > 0)
                {
                    sum += Burger[i].getQuantity() * Burger[i].price;
                }
            }
            return sum;
        }
        private void ArthursBurgerMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(2, "ARTHUR'S BURGER");
            arthursBurgerPictureBox.Enabled = true;
            
        }

        private void MountMacaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(1);
            MountMacaddBtn.Show();
            MountMacMinusBtn.Show();
        }

        private void MountMacMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(1, "MOUNT MAC");
        }

        private void MushroomaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(2);
           
        }
        private void MinusBurger(int i, string name)
        {
            if (Burger[i].getQuantity() > 0)
                Burger[i].DecreaseQuantity();

            if (Burger[i].getQuantity() == 0)
            {
                product2.Text.Replace(name, "");
            }
            ItemPrice2.Text = "$" + getBurgersPrice().ToString();
        }

        private void AddBurger(int i)
        {
            Burger[i].IncreaseQuantity();
            ItemPrice2.Text = "$" + getBurgersPrice().ToString();
        }

        private void MushroomSwissMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(2, "MUSHROOM 'N' SWISS");
        }

        private void ClassicChickaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(3);
        }

        private void ClassicChickMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(3, "CLASSIC CHICK");
        }

        private void LuciferaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(4);
        }

        private void LuciferMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(4, "LUCIFER");
        }

        private void PestoaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(5);
        }

        private void PestoMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(4, "PESTO BASIL");
        }
    }
}