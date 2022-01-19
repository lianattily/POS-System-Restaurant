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
            //this.Hide();
            CustomOrder CustomOrderForm = new CustomOrder();
            CustomOrderForm.Show();
        }

        private void updateTotalLabel()
        {
            
            if (total >= 0)
                TOTAL_Label.Text = "$" + total.ToString();
            else TOTAL_Label.Text = "$0";
        }
        private void updatePrice()
        {
            total = 0;
            for (int i = 0; i < allItems.Count; i++)
            {
                
                total += allItems[i].price* allItems[i].getQuantity(); //MessageBox.Show(allItems[i].name+ " : "+ allItems[i].getQuantity());
            }
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
        private bool checkTextBox(string name, string textbox)
        {
            string[] text = textbox.Split(new string[] { "\r\n", "\r", "\n" },
                                        StringSplitOptions.None);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == name) return false;
            }
            return true;
        }
        private void updateBurgers(int i, string name)
        {
            if (checkTextBox(name, product2.Text))//if(product2.Text.Contains(name)!=true)
                product2.Text += Burger[i].name + "\r\n";
            Burger[i].IncreaseQuantity();
            ItemPrice2.Text = "$" + getBurgersPrice().ToString();//ItemPrice2.Text = Burger[i].price.ToString();
            total += Burger[i].price;
            if (!allItems.Contains(Burger[i]))
                allItems.Add(Burger[i]);
            updateTotalLabel();
            updateBurgerQTY();
        }
        //BURGERS
        private void lucifer_Click(object sender, EventArgs e)
        {
            updateBurgers(5, "LUCIFER");
        }

        private void classicChickPictureBox_Click(object sender, EventArgs e)
        {
            updateBurgers(4, "CLASSIC CHICK");
        }

        private void mushroomNswissPictureBox_Click(object sender, EventArgs e)
        {
            updateBurgers(1, "MUSHROOM 'N' SWISS");
        }

        private void arthursBurgerPictureBox_Click(object sender, EventArgs e)
        {
            updateBurgers(0, "ARTHUR'S BURGER");

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
            if (checkTextBox(name, product4.Text))//if (product4.Text.Contains(name) != true)
                product4.Text += Drinks[i].name + "\r\n";
            Drinks[i].IncreaseQuantity();
            ItemPrice4.Text = "$" + getDrinksPrice();//Burger[i].price.ToString();
            total += Drinks[i].price;

            if (!allItems.Contains(Drinks[i]))
                allItems.Add(Drinks[i]);
            updateDrinksQTY();
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
            updateDrinks(3, "JUICE");
        }

        private void redbullPictureBox_Click(object sender, EventArgs e)
        {
            updateDrinks(4, "REDBULL");
        }


        private void updateStarters(int i, string name)
        {
           
            name = Starters[i].name;
            if (checkTextBox(name, product1.Text)) //if (product1.Text.Contains(name) != true)
                product1.Text += Starters[i].name + "\r\n";
            Starters[i].IncreaseQuantity();
            ItemPrice1.Text = "$" + getStartersPrice();// Starters[i].price.ToString();
            total += Starters[i].price;
            allItems.Add(Starters[i]);
            updateTotalLabel();
            updateStartersQTY();
        }
        //STARTERS
        private void gravyTendersPictureBox_Click(object sender, EventArgs e)
        {
            updateStarters(0, "GRAVY TENDERS");
            
        }

        private void pattyFriesPictureBox_Click(object sender, EventArgs e)
        {
            updateStarters(1, "PATTY FRIES");
        }

        private void dreamyMashedPictureBox_Click(object sender, EventArgs e)
        {
            updateStarters(4, "");
        }

        private void macNcheesePictureBox_Click(object sender, EventArgs e)
        {
            updateStarters(3, "MAC N CHEESE");
        }

        private void luciferBitesPictureBox_Click(object sender, EventArgs e)
        {
            updateStarters(2, "LUCIFER BITES");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void updateTowers(int i, string name)
        {
            if (checkTextBox(name, product3.Text))
            {
                product3.Text += Towers[i].name + "\r\n";
            }
            Towers[i].IncreaseQuantity();
            ItemPrice3.Text = "$" + getTowersPrice();
            total += Towers[i].price;
            allItems.Add(Towers[i]);
            updateTotalLabel();
            updateTowersQTY();
        }
        //TOWERS
        private void beefTowerPictureBox_Click_1(object sender, EventArgs e)
        {
            updateTowers(0, "BEEF TOWER");
        }

        private void chickenTowerPictureBox_Click(object sender, EventArgs e)
        {
            updateTowers(1, "CHICKEN TOWER");
        }

        private void luciferTowerPictureBox_Click(object sender, EventArgs e)
        {
            updateTowers(2, "LUCIFER TOWER");
        }

        Order order;
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            //CREATE ORDER
            order = new Order(allItems);
            Reciept Recieptform = new Reciept(order);
            Recieptform.Show();
            Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void Clear()
        {
            string sql = "update CustomItems set Quantity = NULL where quantity > 0;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();


            product1.Text = " ";
            product2.Text = " ";
            product3.Text = " ";
            product4.Text = " ";
            ItemPrice1.Text = "$";
            ItemPrice2.Text = "$";
            ItemPrice3.Text = "$";
            ItemPrice4.Text = "$";
            TOTAL_Label.Text = "$";
            total = 0;
            allItems.Clear();
            for (int i = 0; i < Burger.Count; i++) Burger[i].clearQuantity();
            for (int i = 0; i < Drinks.Count; i++) Drinks[i].clearQuantity();
            for (int i = 0; i < Towers.Count; i++) Towers[i].clearQuantity();
            for (int i = 0; i < Starters.Count; i++) Starters[i].clearQuantity();
            updateBurgerQTY();
            updateDrinksQTY();
            updateStartersQTY();
            updateTowersQTY();
        }
        private void updateBurgerQTY()
        {
            BQTY1.Text = Burger[0].getQuantity().ToString();
            BQTY2.Text = Burger[2].getQuantity().ToString();
            BQTY3.Text = Burger[1].getQuantity().ToString();
            BQTY4.Text = Burger[4].getQuantity().ToString();
            BQTY5.Text = Burger[5].getQuantity().ToString();
            BQTY6.Text = Burger[3].getQuantity().ToString();

        }
        private void updateStartersQTY()
        {
            SQTY1.Text = Starters[0].getQuantity().ToString();
            SQTY2.Text = Starters[1].getQuantity().ToString();
            SQTY3.Text = Starters[4].getQuantity().ToString();
            SQTY4.Text = Starters[3].getQuantity().ToString();
            SQTY5.Text = Starters[2].getQuantity().ToString();
        }

        private void updateDrinksQTY()
        {
            DQTY1.Text = Drinks[0].getQuantity().ToString();
            DQTY2.Text = Drinks[1].getQuantity().ToString();
            DQTY3.Text = Drinks[2].getQuantity().ToString();
            DQTY4.Text = Drinks[3].getQuantity().ToString();
            DQTY5.Text = Drinks[4].getQuantity().ToString();
        }

        private void updateTowersQTY()
        {
            TQTY1.Text = Towers[0].getQuantity().ToString();
            TQTY2.Text = Towers[1].getQuantity().ToString();
            TQTY3.Text = Towers[2].getQuantity().ToString();

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
        private string getStartersPrice()
        {
            double price = 0;
            for (int i = 0; i < Starters.Count; i++)
            {
                price += Starters[i].price * Starters[i].getQuantity();
            }

            return price.ToString();
        }

        private string getDrinksPrice()
        {
            double price = 0;
            for (int i = 0; i < Drinks.Count; i++)
            {
                price += Drinks[i].price * Drinks[i].getQuantity();
            }

            return price.ToString();
        }

        private void ArthursBurgeraddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(0);

        }

        private double getBurgersPrice()
        {
            double sum = 0;
            for (int i = 0; i < Burger.Count; i++)
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
            MinusBurger(0, "ARTHUR'S BURGER");
            arthursBurgerPictureBox.Enabled = true;

        }

        private void MountMacaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(2);
        }

        private void MountMacMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(2, "MOUNT MAC");
        }

        private void MushroomaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(1);

        }
        private void AddBurger(int i)
        {
            if (checkTextBox(Burger[i].name, product2.Text))
                product2.Text += Burger[i].name + "\r\n";

            Burger[i].IncreaseQuantity();
            total += Burger[i].price;
            if (!allItems.Contains(Burger[i]))
                allItems.Add(Burger[i]);
            
            updateTotalLabel();
            ItemPrice2.Text = "$" + getBurgersPrice().ToString();
            updateBurgerQTY();
        }
        private void MinusBurger(int i, string name)
        {

            if (Burger[i].getQuantity() > 0)
                Burger[i].DecreaseQuantity();
            if (Burger[i].getQuantity() == 0)
            {
                product2.Text = removeItemText(name, product2.Text);
            }

            ItemPrice2.Text = "$" + getBurgersPrice().ToString();

            //Update items list
            for (int j = 0; j < allItems.Count; j++)
            {
                if (Burger[i].name == allItems[j].name)
                {
                    //IF QUANTITY = 0, REMOVE ITEM FROM ALL ITEMS LIST
                    if (Burger[i].getQuantity() == 0) allItems.RemoveAt(j);
                    else 
                        allItems[j] = Burger[i]; 
                }
            }
            total -= Burger[i].price;
            updatePrice();
            updateTotalLabel();
            updateBurgerQTY();
        }
        private string removeItemText(string name, string textbox)
        {

            string[] lines = textbox.Split("\r\n".ToCharArray());
            string richText = string.Empty;
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                
                if (lines[i] != name && !string.IsNullOrWhiteSpace(lines[i]))
                {
                    richText += lines[i] + "\r\n";
                }
            }
            return richText;

        }

        private void AddDrink(int i)
        {
            //MessageBox.Show(Drinks[i].name);
            if (checkTextBox(Drinks[i].name, product4.Text))
                product4.Text += Drinks[i].name + "\r\n";

            Drinks[i].IncreaseQuantity();
            total += Drinks[i].price;
            if (!allItems.Contains(Drinks[i]))
                allItems.Add(Drinks[i]);
            updateTotalLabel();
            ItemPrice4.Text = "$" + getDrinksPrice().ToString();
            updateDrinksQTY();

        }
        private void MinusDrink(int i, string name)
        {
            name = Drinks[i].name;
            if (Drinks[i].getQuantity() > 0)
                Drinks[i].DecreaseQuantity();
            if (Drinks[i].getQuantity() == 0)
            {
                product4.Text = removeItemText(name, product4.Text);//product2.Text.Replace(name, "");
            }

            ItemPrice4.Text = "$" + getDrinksPrice().ToString();

            //Update items list
            for (int j = 0; j < allItems.Count; j++)
            {
                if (Drinks[i].name == allItems[j].name)
                {
                    //IF QUANTITY = 0, REMOVE ITEM FROM ALL ITEMS LIST
                    if (Drinks[i].getQuantity() == 0) allItems.RemoveAt(j);
                    else //ELSE DECREASE QUANTITY OF ALLITEMS[j]
                        allItems[j] = Drinks[i];//.DecreaseQuantity();
                }
            }
            total -= Drinks[i].price;
            updatePrice();
            updateTotalLabel();
            updateDrinksQTY();
        }

        private void AddTowers(int i)
        {
            if (checkTextBox(Towers[i].name, product3.Text))
                product3.Text += Towers[i].name + "\r\n";

            Towers[i].IncreaseQuantity();
            total += Towers[i].price;
            if (!allItems.Contains(Towers[i]))
                allItems.Add(Towers[i]);
            updateTotalLabel();
            ItemPrice3.Text = "$" + getTowersPrice().ToString();
            updateTowersQTY();
        }

        private void MinusTower(int i, string name)
        {
            name = Towers[i].name;
            if (Towers[i].getQuantity() > 0)
                Towers[i].DecreaseQuantity();
            if (Towers[i].getQuantity() == 0)
            {
                product3.Text = removeItemText(name, product3.Text);
            }

            ItemPrice3.Text = "$" + getTowersPrice().ToString();

            //Update items list
            for (int j = 0; j < allItems.Count; j++)
            {
                if (Towers[i].name == allItems[j].name)
                {
                    //IF QUANTITY = 0, REMOVE ITEM FROM ALL ITEMS LIST
                    if (Towers[i].getQuantity() == 0) allItems.RemoveAt(j);
                    else //ELSE DECREASE QUANTITY OF ALLITEMS[j]
                        allItems[j] = Towers[i];//.DecreaseQuantity();
                }
            }
            total -= Towers[i].price;
            updatePrice();
            updateTotalLabel();
            updateTowersQTY();
        }

        private void AddStarters(int i)
        {
            if (checkTextBox(Starters[i].name, product1.Text))
                product1.Text += Starters[i].name + "\r\n";

            Starters[i].IncreaseQuantity();
            total += Starters[i].price;
            if (!allItems.Contains(Starters[i]))
                allItems.Add(Starters[i]);
            updateTotalLabel();
            ItemPrice1.Text = "$" + getStartersPrice().ToString();
            updateStartersQTY();
        }

        private void MinusStarters(int i, string name)
        {
            name = Starters[i].name;
            if (Starters[i].getQuantity() > 0)
                Starters[i].DecreaseQuantity();
            if (Starters[i].getQuantity() == 0)
            {
                product1.Text = removeItemText(name, product1.Text); //product2.Text.Replace(name, "");
            }

            ItemPrice1.Text = "$" + getStartersPrice().ToString();

            //Update items list
            for (int j = 0; j < allItems.Count; j++)
            {
                if (Starters[i].name == allItems[j].name)
                {
                    //IF QUANTITY = 0, REMOVE ITEM FROM ALL ITEMS LIST
                    if (Starters[i].getQuantity() == 0) allItems.RemoveAt(j);
                    else //ELSE DECREASE QUANTITY OF ALLITEMS[j]
                        allItems[j] = Starters[i];//.DecreaseQuantity();
                }
            }
            total -= Starters[i].price;
            updatePrice();
            updateTotalLabel();
            updateStartersQTY();
        }
        private void MushroomSwissMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(1, "MUSHROOM 'N' SWISS");
        }

        private void ClassicChickaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(4);
        }

        private void ClassicChickMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(4, "CLASSIC CHICK");
        }

        private void LuciferaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(5);
        }

        private void LuciferMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(5, "LUCIFER");
        }

        private void PestoaddBtn_Click(object sender, EventArgs e)
        {
            AddBurger(3);
        }

        private void PestoMinusBtn_Click(object sender, EventArgs e)
        {
            MinusBurger(3, "PESTO BASIL");
        }

        private void GravyAdd_Click(object sender, EventArgs e)
        {
            AddStarters(0);

        }

        private void GravyMinus_Click(object sender, EventArgs e)
        {
            MinusStarters(0, "");
        }

        private void PattyAdd_Click(object sender, EventArgs e)
        {
            AddStarters(1);
        }

        private void PattyMinus_Click(object sender, EventArgs e)
        {
            MinusStarters(1, "");
        }

        private void DreamyAdd_Click(object sender, EventArgs e)
        {
            AddStarters(4);
        }

        private void DreamyMinus_Click(object sender, EventArgs e)
        {
            MinusStarters(4, "");
        }

        private void MacNCheeseAdd_Click(object sender, EventArgs e)
        {
            AddStarters(3);
        }

        private void MacNCheeseMinus_Click(object sender, EventArgs e)
        {
            MinusStarters(3, "");
        }

        private void LuciferBitesMinus_Click(object sender, EventArgs e)
        {
            MinusStarters(2, "");
        }

        private void LuciferBitesAdd_Click(object sender, EventArgs e)
        {
            AddStarters(2);
        }

        private void SoftAdd_Click(object sender, EventArgs e)
        {
            AddDrink(0);
        }

        private void SoftMinus_Click(object sender, EventArgs e)
        {
            MinusDrink(0, "");
        }

        private void SparklingAdd_Click(object sender, EventArgs e)
        {
            AddDrink(2);
        }

        private void SparklingMinus_Click(object sender, EventArgs e)
        {
            MinusDrink(2, "");
        }

        private void juiceAdd_Click(object sender, EventArgs e)
        {
            AddDrink(3);
        }

        private void juiceMinus_Click(object sender, EventArgs e)
        {
            MinusDrink(3, "");
        }

        private void RedbullAdd_Click(object sender, EventArgs e)
        {
            AddDrink(4);
        }

        private void RedbullMinus_Click(object sender, EventArgs e)
        {
            MinusDrink(4, "");
        }

        private void WaterAdd_Click(object sender, EventArgs e)
        {
            AddDrink(1);
        }

        private void WaterMinus_Click(object sender, EventArgs e)
        {
            MinusDrink(1, "");
        }

        private void BeefTowerAdd_Click(object sender, EventArgs e)
        {
            AddTowers(0);
        }

        private void BeefTowerMinus_Click(object sender, EventArgs e)
        {
            MinusTower(0, "");
        }

        private void ChickenTowerAdd_Click(object sender, EventArgs e)
        {
            AddTowers(1);
        }

        private void ChickenTowerMinus_Click(object sender, EventArgs e)
        {
            MinusTower(1, "");
        }

        private void LuciferTowerAdd_Click(object sender, EventArgs e)
        {
            AddTowers(2);
        }

        private void LuciferTowerMinus_Click(object sender, EventArgs e)
        {
            MinusTower(2, "");
        }
    }
}