using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revolution_
{
    public class BookItem
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private string Image { get; set; }

        public BookItem(int ID,string ISBN, string Product_Name, double Price, int Quantity,string Image)
        {
            this.ID = ID;
            this.ISBN = ISBN;
            this.Product_Name = Product_Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Image = Image;
        }

    }
}