using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_Arthurs
{
    class Item
    {

        public int ID { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        private int quantity=0;

        public Item()
        {

        }

        public Item(string name,int quantity, double price = 0)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public int IncreaseQuantity()
        {
            quantity++;
            return quantity;
        }

        public int DecreaseQuantity()
        {
            quantity--;
            return quantity;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void clearQuantity()
        {
            quantity = 0;
        }

        public void setQuantity(int qty)
        {
            quantity = qty;
        }
    }
}
