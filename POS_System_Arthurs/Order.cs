using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_Arthurs
{
    class Order
    {
        private double total = 0;
        private int quantity = 0;
        private List<Item> items = new List<Item>();
        public Order(List<Item> OrderItems)
        {
            if (OrderItems.Count == 0)
            {
                return;
            }
            for (int i = 0; i < OrderItems.Count; i++)
            {
                items.Add(OrderItems[i]);
                total += OrderItems[i].price;
            }

        }

        public void IncreaseQuantity(Item item)
        {

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == item.name) items[i].IncreaseQuantity();
            }
        }

        public void DecreaseQuantity(Item item)
        {

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == item.name) items[i].DecreaseQuantity();
            }
        }

        public List<Item> getItems()
        {
            return items;
        }
        public void AddItem(Item item)
        {
            items.Add(item);
            total += item.price;
        }
        public double getTotal()
        {
            return total;
        }
        public void addToTotal(double t)
        {
            total += t;
        }
    }
}

