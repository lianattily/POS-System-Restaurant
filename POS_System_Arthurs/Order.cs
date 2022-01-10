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
        private List<Item> items;
        public Order(List<Item> OrderItems)
        {
            for(int i=0; i< OrderItems.Count;i++){
                items.Add(OrderItems[i]);
                total += OrderItems[i].price;
            }

        }

        public void IncreaseQuantity()
        {

        }

        public void DecreaseQuantity()
        {

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
    }
}
