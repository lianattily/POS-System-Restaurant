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
        List<Item> items = new List<Item>();
       
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
            bunPanel.Visible = true;
            bunPanel.Dock = DockStyle.Fill;
            meatPanel.Dock = DockStyle.Fill;
            freshPanel.Dock = DockStyle.Fill;
            cheesePanel.Dock = DockStyle.Fill;
            saucePanel.Dock = DockStyle.Fill;
            makeItTastyPanel.Dock = DockStyle.Fill;
            reviewPanel.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bunPanel.Visible = false;
            meatPanel.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            meatPanel.Visible = false;
            bunPanel.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            meatPanel.Visible = false;
            freshPanel.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            freshPanel.Visible = false;
            meatPanel.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            freshPanel.Visible = false;
            cheesePanel.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cheesePanel.Visible = false;
            freshPanel.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cheesePanel.Visible = false;
            saucePanel.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            saucePanel.Visible = false;
            cheesePanel.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            saucePanel.Visible = false;
            makeItTastyPanel.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            makeItTastyPanel.Visible = false;
            saucePanel.Visible = true;
        }

        private void glazedPictureBox_Click(object sender, EventArgs e)
        {
            glazedBunRadioButton.Checked = true;
        }

        private void pretzelPictureBox_Click(object sender, EventArgs e)
        {
            pretzelBunRadioButton.Checked = true;
        }

        private void lettuceWrapPictureBox_Click(object sender, EventArgs e)
        {
            lettuceWrapRadioButton.Checked = true;
        }

        private void potatoPictureBox_Click(object sender, EventArgs e)
        {
            potatoBunRadioButton.Checked = true;
        }

        private void ketchupPictureBox_Click(object sender, EventArgs e)
        {
            if (ketchupCheckBox.Checked = true && ketchupCheckBox.CheckState == CheckState.Checked)
                ketchupCheckBox.Checked = false;

            else
                ketchupCheckBox.Checked = true;
        }

        private void mayoPictureBox_Click(object sender, EventArgs e)
        {
            if (mayoCheckBox.Checked = true && mayoCheckBox.CheckState == CheckState.Checked)
                mayoCheckBox.Checked = false;

            else
                mayoCheckBox.Checked = true;
        }

        private void mustardPictureBox_Click(object sender, EventArgs e)
        {
            if (mustardCheckBox.Checked = true && mustardCheckBox.CheckState == CheckState.Checked)
                mustardCheckBox.Checked = false;

            else
                mustardCheckBox.Checked = true;
        }

        private void satsebeliPictureBox_Click(object sender, EventArgs e)
        {
            if (satsebeliCheckBox.Checked = true && satsebeliCheckBox.CheckState == CheckState.Checked)
                satsebeliCheckBox.Checked = false;

            else
                satsebeliCheckBox.Checked = true;
        }

        private void beefAddBtn_Click(object sender, EventArgs e)
        {
            if (beefLabel.Text == "")
                beefLabel.Text = "1";
            else
            {
                int x = int.Parse(beefLabel.Text);
                x++;
                beefLabel.Text = x.ToString();
            }
        }

        private void beefPictureBox_Click(object sender, EventArgs e)
        {
            if (beefLabel.Text == "")
                beefLabel.Text = "1";
            else
            {
                int x = int.Parse(beefLabel.Text);
                x++;
                beefLabel.Text = x.ToString();
            }
        }

        private void beefMinusBtn_Click(object sender, EventArgs e)
        {
            if (beefLabel.Text == "" || beefLabel.Text == "1")
                beefLabel.Text = "";
            else
            {
                int x = int.Parse((beefLabel.Text));
                x--;
                beefLabel.Text = x.ToString();
            }
        }

        private void chickenPictureBox_Click(object sender, EventArgs e)
        {
            if (chickenLabel.Text == "")
                chickenLabel.Text = "1";
            else
            {
                int x = int.Parse(chickenLabel.Text);
                x++;
                chickenLabel.Text = x.ToString();
            }
        }

        private void chickenMinusBtn_Click(object sender, EventArgs e)
        {
            if (chickenLabel.Text == "" || chickenLabel.Text == "1")
                chickenLabel.Text = "";
            else
            {
                int x = int.Parse((chickenLabel.Text));
                x--;
                chickenLabel.Text = x.ToString();
            }
        }

        private void chickenAddBtn_Click(object sender, EventArgs e)
        {
            if (chickenLabel.Text == "")
                chickenLabel.Text = "1";
            else
            {
                int x = int.Parse(chickenLabel.Text);
                x++;
                chickenLabel.Text = x.ToString();
            }
        }

        private void classicMinusBtn_Click(object sender, EventArgs e)
        {
            if (classicLabel.Text == "" || classicLabel.Text == "1")
                classicLabel.Text = "";
            else
            {
                int x = int.Parse((classicLabel.Text));
                x--;
                classicLabel.Text = x.ToString();
            }
        }

        private void classicAddButton_Click(object sender, EventArgs e)
        {
            if (classicLabel.Text == "")
                classicLabel.Text = "1";
            else
            {
                int x = int.Parse(classicLabel.Text);
                x++;
                classicLabel.Text = x.ToString();
            }
        }

        private void classicPictureBox_Click(object sender, EventArgs e)
        {
            if (classicLabel.Text == "")
                classicLabel.Text = "1";
            else
            {
                int x = int.Parse(classicLabel.Text);
                x++;
                classicLabel.Text = x.ToString();
            }
        }

        private void pepperJackMinusBtn_Click(object sender, EventArgs e)
        {
            if (pepperJackLabel.Text == "" || pepperJackLabel.Text == "1")
                pepperJackLabel.Text = "";
            else
            {
                int x = int.Parse((pepperJackLabel.Text));
                x--;
                pepperJackLabel.Text = x.ToString();
            }
        }

        private void pepperJackAddBtn_Click(object sender, EventArgs e)
        {
            if (pepperJackLabel.Text == "")
                pepperJackLabel.Text = "1";
            else
            {
                int x = int.Parse(pepperJackLabel.Text);
                x++;
                pepperJackLabel.Text = x.ToString();
            }
        }

        private void pepperJackPictureBox_Click(object sender, EventArgs e)
        {
            if (pepperJackLabel.Text == "")
                pepperJackLabel.Text = "1";
            else
            {
                int x = int.Parse(pepperJackLabel.Text);
                x++;
                pepperJackLabel.Text = x.ToString();
            }
        }

        private void swissMinusBtn_Click(object sender, EventArgs e)
        {
            if (swissLabel.Text == "" || swissLabel.Text == "1")
                swissLabel.Text = "";
            else
            {
                int x = int.Parse((swissLabel.Text));
                x--;
                swissLabel.Text = x.ToString();
            }
        }

        private void swissAddBtn_Click(object sender, EventArgs e)
        {
            if (swissLabel.Text == "")
                swissLabel.Text = "1";
            else
            {
                int x = int.Parse(swissLabel.Text);
                x++;
                swissLabel.Text = x.ToString();
            }
        }

        private void swissPictureBox_Click(object sender, EventArgs e)
        {
            if (swissLabel.Text == "")
                swissLabel.Text = "1";
            else
            {
                int x = int.Parse(swissLabel.Text);
                x++;
                swissLabel.Text = x.ToString();
            }
        }

        private void baconAddBtn_Click(object sender, EventArgs e)
        {
            if (baconLabel.Text == "")
                baconLabel.Text = "1";
            else
            {
                int x = int.Parse(baconLabel.Text);
                x++;
                baconLabel.Text = x.ToString();
            }
        }

        private void baconMinusBtn_Click(object sender, EventArgs e)
        {
            if (baconLabel.Text == "" || baconLabel.Text == "1")
                baconLabel.Text = "";
            else
            {
                int x = int.Parse((baconLabel.Text));
                x--;
                baconLabel.Text = x.ToString();
            }
        }

        private void baconPictureBox_Click(object sender, EventArgs e)
        {
            if (baconLabel.Text == "")
                baconLabel.Text = "1";
            else
            {
                int x = int.Parse(baconLabel.Text);
                x++;
                baconLabel.Text = x.ToString();
            }
        }

        private void mushroomAddBtn_Click(object sender, EventArgs e)
        {
            if (mushroomLabel.Text == "")
                mushroomLabel.Text = "1";
            else
            {
                int x = int.Parse(mushroomLabel.Text);
                x++;
                mushroomLabel.Text = x.ToString();
            }
        }

        private void mushroomMinusBtn_Click(object sender, EventArgs e)
        {
            if (mushroomLabel.Text == "" || mushroomLabel.Text == "1")
                mushroomLabel.Text = "";
            else
            {
                int x = int.Parse((mushroomLabel.Text));
                x--;
                mushroomLabel.Text = x.ToString();
            }
        }

        private void mushroomPictureBox_Click(object sender, EventArgs e)
        {
            if (mushroomLabel.Text == "")
                mushroomLabel.Text = "1";
            else
            {
                int x = int.Parse(mushroomLabel.Text);
                x++;
                mushroomLabel.Text = x.ToString();
            }
        }

        private void tortillaAddBtn_Click(object sender, EventArgs e)
        {
            if (tortillaLabel.Text == "")
                tortillaLabel.Text = "1";
            else
            {
                int x = int.Parse(tortillaLabel.Text);
                x++;
                tortillaLabel.Text = x.ToString();
            }
        }

        private void tortillaMinusBtn_Click(object sender, EventArgs e)
        {
            if (tortillaLabel.Text == "" || tortillaLabel.Text == "1")
                tortillaLabel.Text = "";
            else
            {
                int x = int.Parse((tortillaLabel.Text));
                x--;
                tortillaLabel.Text = x.ToString();
            }
        }

        private void tortillaPictureBox_Click(object sender, EventArgs e)
        {
            if (tortillaLabel.Text == "")
                tortillaLabel.Text = "1";
            else
            {
                int x = int.Parse(tortillaLabel.Text);
                x++;
                tortillaLabel.Text = x.ToString();
            }
        }

        private void guacamoleAddBtn_Click(object sender, EventArgs e)
        {
            if (guacLabel.Text == "")
                guacLabel.Text = "1";
            else
            {
                int x = int.Parse(guacLabel.Text);
                x++;
                guacLabel.Text = x.ToString();
            }
        }

        private void guacamoleMinusBtn_Click(object sender, EventArgs e)
        {
            if (guacLabel.Text == "" || guacLabel.Text == "1")
                guacLabel.Text = "";
            else
            {
                int x = int.Parse((guacLabel.Text));
                x--;
                guacLabel.Text = x.ToString();
            }
        }

        private void guacamolePictureBox_Click(object sender, EventArgs e)
        {
            if (guacLabel.Text == "")
                guacLabel.Text = "1";
            else
            {
                int x = int.Parse(guacLabel.Text);
                x++;
                guacLabel.Text = x.ToString();
            }
        }

        private void lettucePictureBox_Click(object sender, EventArgs e)
        {
            if (lettuceCheckBox.Checked = true && lettuceCheckBox.CheckState == CheckState.Checked)
                lettuceCheckBox.Checked = false;

            else
                lettuceCheckBox.Checked = true;
        }

        private void tomatoPictureBox_Click(object sender, EventArgs e)
        {
            if (tomatoCheckBox.Checked = true && tomatoCheckBox.CheckState == CheckState.Checked)
                tomatoCheckBox.Checked = false;

            else
                tomatoCheckBox.Checked = true;
        }

        private void picklePictureBox_Click(object sender, EventArgs e)
        {
            if (picklesCheckBox.Checked = true && picklesCheckBox.CheckState == CheckState.Checked)
                picklesCheckBox.Checked = false;

            else
                picklesCheckBox.Checked = true;
        }

        private void onionPictureBox_Click(object sender, EventArgs e)
        {
            if (redOnionCheckBox.Checked = true && redOnionCheckBox.CheckState == CheckState.Checked)
                redOnionCheckBox.Checked = false;

            else
                redOnionCheckBox.Checked = true;
        }

        private void jalapenoPictureBox_Click(object sender, EventArgs e)
        {
            if (jalapenoCheckBox.Checked = true && jalapenoCheckBox.CheckState == CheckState.Checked)
                jalapenoCheckBox.Checked = false;

            else
                jalapenoCheckBox.Checked = true;
        }

        private void caramelizedPictureBox_Click(object sender, EventArgs e)
        {
            if (caramelizedOnionsCheckBox.Checked = true && caramelizedOnionsCheckBox.CheckState == CheckState.Checked)
                caramelizedOnionsCheckBox.Checked = false;

            else
                caramelizedOnionsCheckBox.Checked = true;
        }

        private void startOver()
        {
            this.Hide();
            CustomOrder customOrder = new CustomOrder();
            customOrder.Show();
        }

        private void startOver1_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void startOver2_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void startOver3_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void startOver4_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void startOver5_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void startOver6_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void cancel()
        {
            this.Hide();   
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel3_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel4_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel5_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel6_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ingredientsListBox.Items.Clear();
            priceListBox.Items.Clear();
            items.Clear();
            makeItTastyPanel.Visible = true;
            reviewPanel.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            review(makeItTastyPanel);
            makeItTastyPanel.Visible = false;
            reviewPanel.Visible = true;
        }

        private void CustomOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(); 
        }

        private void done1_Click(object sender, EventArgs e)
        {
            review(bunPanel);
        }

        private void done4_Click(object sender, EventArgs e)
        {
            review(cheesePanel);
        }

        private void done5_Click(object sender, EventArgs e)
        {
            review(saucePanel);
        }

        private void done6_Click(object sender, EventArgs e)
        {
            review(makeItTastyPanel);
        }

        private void done3_Click(object sender, EventArgs e)
        {
            review(freshPanel);
        }

        private void done2_Click(object sender, EventArgs e)
        {
            review(meatPanel);
        }

        private void review(Panel panel)
        {
            if (glazedBunRadioButton.Checked)
            {
                Item glazed = new Item("Glazed bun", 1);
                items.Add(glazed);
            }

            else if (lettuceCheckBox.Checked)
            {
                Item wrap = new Item("Lettuce wrap", 1);
                items.Add(wrap);
            }

            else if (pretzelBunRadioButton.Checked)
            {
                Item pretzel = new Item("Pretzel bun", 1);
                items.Add(pretzel);
            }

            else
            {
                Item potato = new Item("Potato bun", 1);
                items.Add(potato);
            }

            if (beefLabel.Text != "")
            {
                Item beef = new Item("Beef", int.Parse(beefLabel.Text), 2);
                items.Add(beef);
            }

            if (chickenLabel.Text != "")
            {
                Item chicken = new Item("Chicken", int.Parse(chickenLabel.Text), 1.6);
                items.Add(chicken);
            }

            if (lettuceCheckBox.Checked)
            {
                Item lettuce = new Item("Whole leaf lettuce", 1);
                items.Add(lettuce);
            }

            if (picklesCheckBox.Checked)
            {
                Item pickles = new Item("Sliced pickles", 1);
                items.Add(pickles);
            }

            if (tomatoCheckBox.Checked)
            {
                Item tomato = new Item("Sliced tomato", 1);
                items.Add(tomato);
            }

            if (redOnionCheckBox.Checked)
            {
                Item onion = new Item("Red onion rings", 1);
                items.Add(onion);
            }

            if (jalapenoCheckBox.Checked)
            {
                Item jalapeno = new Item("Sliced jalapeno", 1);
                items.Add(jalapeno);
            }

            if (caramelizedOnionsCheckBox.Checked)
            {
                Item caramelized = new Item("Caramelized onion", 1);
                items.Add(caramelized);
            }

            if (classicLabel.Text != "")
            {
                Item classic = new Item("Classic cheese", int.Parse(classicLabel.Text), 0.6);
                items.Add(classic);
            }

            if (swissLabel.Text != "")
            {
                Item swiss = new Item("Swiss cheese", int.Parse((swissLabel.Text)), 0.6);
                items.Add(swiss);
            }

            if (pepperJackLabel.Text != "")
            {
                Item pepperJack = new Item("Pepper jack cheese", int.Parse(pepperJackLabel.Text), 0.6);
                items.Add((pepperJack));
            }

            if (ketchupCheckBox.Checked)
            {
                Item ketchup = new Item("Ketchup", 1);
                items.Add(ketchup);
            }

            if (mayoCheckBox.Checked)
            {
                Item mayo = new Item("Mayonnaise", 1);
                items.Add(mayo);
            }

            if (mustardCheckBox.Checked)
            {
                Item mustard = new Item("Mustard", 1);
                items.Add(mustard);
            }

            if (satsebeliCheckBox.Checked)
            {
                Item satsebeli = new Item("Satsebeli", 1);
                items.Add(satsebeli);
            }

            if (baconLabel.Text != "")
            {
                Item bacon = new Item("Beef bacon", int.Parse(baconLabel.Text), 1.2);
                items.Add(bacon);
            }

            if (mushroomLabel.Text != "")
            {
                Item mushroom = new Item("Grilled mushrooms", int.Parse(mushroomLabel.Text), 0.6);
                items.Add(mushroom);
            }

            if (tortillaLabel.Text != "")
            {
                Item tortilla = new Item("Tortilla strips", int.Parse(tortillaLabel.Text), 0.6);
                items.Add(tortilla);
            }

            if (guacLabel.Text != "")
            {
                Item guac = new Item("Guacamole", int.Parse(guacLabel.Text), 0.6);
                items.Add(guac);
            }

            ingredientsListBox.Items.Add("Item");
            ingredientsListBox.Items.Add("--------------------------");
            priceListBox.Items.Add("Price");
            priceListBox.Items.Add("--------------------");

            for (int i = 0; i < items.Count; i++)
            {
                ingredientsListBox.Items.Add(items[i].getQuantity().ToString() + "x " + items[i].name);
                if(items[i].price != 0)
                    priceListBox.Items.Add((items[i].getQuantity() * items[i].price).ToString());
                else
                    priceListBox.Items.Add("  -");
            }

            double total = 0;
            foreach (Item item in items)
                total += item.price * item.getQuantity();

            priceLabel.Text = total.ToString();

            panel.Visible = false;
            reviewPanel.Visible = true;
        }

        private void startOver7_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void cancel7_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=menu.sqlite; Version=3;");
            m_dbConnection.Open();

            foreach(Item item in items)
            {
                string sql = "update CUSTOM ITEMS set Quantity = " + item.getQuantity() + " where ItemNames = '" + item.name +"';";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            
        }
    }
}
