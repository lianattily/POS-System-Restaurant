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
    internal partial class Reciept : Form
    {
        List<Item> orderItems = new List<Item>();
        Order order;
        public Reciept()
        {
            InitializeComponent();
        }

        public Reciept(Order order)
        {
            InitializeComponent();

            //initialize Order object and list of items
            orderItems = order.getItems();
            this.order = order;

            //Set titles of summary on reciept
            DateTime now = DateTime.Now;
            TitlesLabel.Text = now.ToString() ;

            TOTAL_Label.Text ="$"+ order.getTotal().ToString();

            //FILL ORDER ITEMS INTO TEXTBOX
            fillItems();
        }
       
        private void fillItems()
        {
            ITEMS.Text = "NAME \t\t\t PRICE \t QUANTITY \n";
            for(int i = 0; i < orderItems.Count; i++)
            {
                ITEMS.Text +="\n"+ orderItems[i].name+"\t $"+ orderItems[i].price + "\t "+orderItems[i].getQuantity() + "\n ";
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }
    }
}
