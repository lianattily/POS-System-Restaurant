using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace POS_System_Arthurs
{
    internal partial class Reciept : Form
    {
        List<Item> CustomItems = new List<Item>();
        List<Item> orderItems = new List<Item>();
        SQLiteConnection m_dbConnection;
        Order order;
        string customOrder;
        public Reciept()
        {
            InitializeComponent();
        }

        public Reciept(Order order)
        {
            
            m_dbConnection = new SQLiteConnection("Data Source=menu.sqlite; Version=3;");
            //CONNECTING TO MENU DATABASE
            try
            {
                m_dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            InitializeComponent();

            //initialize Order object and list of items
            orderItems = order.getItems();
            this.order = order;

            //Set titles of summary on reciept
            DateTime now = DateTime.Now;
            TitlesLabel.Text = now.ToString();

   

            //FILL ORDER ITEMS INTO TEXTBOX
            fillItems();
            fillCustom();         
            TOTAL_Label.Text = "$" + order.getTotal().ToString();
        }

        private void fillCustom()
        {
            string sql = "select * from CustomItems where Quantity is not null;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Item i = new Item();
                
                i.price = double.Parse(reader["Price"].ToString());
                i.name = reader["ItemName"].ToString();
                i.setQuantity(int.Parse(reader["Quantity"].ToString()));
                //MessageBox.Show(i.name);
                CustomItems.Add(i);
            }
            //MessageBox.Show(CustomItems.Count.ToString());
            if (CustomItems.Count > 0)
            {
                
                customOrderLabel.Text = "CUSTOM ITEM";
                //ADD CUSTOM ORDER TOTAL TO ORDER TOTAL
                double total = 0;
                foreach (Item item in CustomItems)
                    total += item.price * item.getQuantity();
                customOrderLabel.Text = "CUSTOM ITEM\t\t\t$"+total.ToString();
                order.addToTotal(total);
            }
            else
                customOrderLabel.Enabled = false;

        }
        private void fillItems()
        {
            ITEMS.Text = "ITEM \r\n";
            QTYPRICE.Text = "PRICE \t QUANTITY \r\n";
            for (int i = 0; i < orderItems.Count; i++)
            {
                ITEMS.Text += orderItems[i].name + "\r\n";
                QTYPRICE.Text += "$" + orderItems[i].price + "\t " + orderItems[i].getQuantity() + "\n ";
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            clearCustomOrder();
        }
        private void clearCustomOrder()
        {
            
            //UPDATING ITEM QUANTITIES;
            foreach (Item item in CustomItems)
            {
                string sql = "update CustomItems set Quantity = NULL where ItemName = '" + item.name + "';";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
        }
        private void Reciept_Load(object sender, EventArgs e)
        {
            //customOrderLabel.Enabled = false;
            panel3.Dock = DockStyle.Fill;
            panel7.Dock = DockStyle.Fill;
        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
            string folder;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                folder = fbd.SelectedPath;
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                }
                if (result == DialogResult.Cancel)
                {

                }
            }
            string lines = ITEMS.Text+"\t"+QTYPRICE.Text;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                string filepath = folder + "\\Order.txt";
                StreamWriter sw = new StreamWriter(filepath);

                sw.WriteLine(lines);
                sw.Close();
                MessageBox.Show("Order file saved successfully", "Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while saving the file :(", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < CustomItems.Count; i++)
            {
                if (CustomItems[i].price != 0)
                    customOrder += CustomItems[i].getQuantity().ToString() + "x " + CustomItems[i].name + "\t\t\t" + CustomItems[i].price + "\n";
                else
                    customOrder += CustomItems[i].getQuantity().ToString() + "x " + CustomItems[i].name + "\t\t\t-\n";
            }
            MessageBox.Show(customOrder, "Custom Order Details");
        }

        private void customOrderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            itemListBox.Items.Add("Item");
            itemListBox.Items.Add("------------------------");
            priceListBox.Items.Add("Price");
            priceListBox.Items.Add("------------------");
            for (int i = 0; i < CustomItems.Count; i++)
            {
                itemListBox.Items.Add(CustomItems[i].getQuantity().ToString() + "x " + CustomItems[i].name);

                if (CustomItems[i].price != 0)
                {
                    priceListBox.Items.Add(CustomItems[i].price.ToString());
                } 
                else
                {                    
                    priceListBox.Items.Add("  -");
                }
                 
            }
             
            panel3.Visible = false;
            panel7.Visible = true;
        }

        private void ITEMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void QTYPRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            panel7.Visible=false;
            panel3.Visible=true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
