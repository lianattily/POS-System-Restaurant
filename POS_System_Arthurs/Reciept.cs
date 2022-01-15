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
            ITEMS.Text = "ITEM \r\n";
            QTYPRICE.Text="PRICE \t QUANTITY \r\n";
            for(int i = 0; i < orderItems.Count; i++)
            {
                ITEMS.Text += orderItems[i].name+"\r\n";
                QTYPRICE.Text+="$"+ orderItems[i].price + "\t "+orderItems[i].getQuantity() + "\n ";
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

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
                if(result == DialogResult.Cancel)
                {

                }
            }
            string lines = ITEMSs.Text;
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
    }
}
