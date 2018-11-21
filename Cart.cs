using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revolution_
{
    public class Cart
    {
        public List<BookItem> Items { get; set; }

        public Cart()
        {
            Items = new List<BookItem>();
        }

        private int ItemIndexOf(int id)
        {
            foreach(BookItem item in Items)
            {
                if(item.ID == id)
                {
                    return Items.IndexOf(item);
                }
            }
            return -1;
        }
        public void insert(BookItem item)
        {
            int index = ItemIndexOf(item.ID);
            if(index == -1)
            {
                Items.Add(item);
            }
            else
            {
                Items[index].Quantity++;
            }
        }

        public void delete(int rowID)
        {
            Items.RemoveAt(rowID);
        }

        public void update(int rowID, int Quantity)
        {
            if(Quantity > 0)
            {
                Items[rowID].Quantity = Quantity;
            }
            else
            {
                delete(rowID);
            }
        }

        public double GrandTotal
        {
            get
            {
                if(Items == null)
                {
                    return 0;
                }
                else
                {
                    double grandTotal = 0;
                    foreach(BookItem item in Items)
                    {
                        grandTotal += item.Quantity * item.Price;
                    }
                    return grandTotal;
                }
            }
        }
    }
}