using System;

namespace Bookstore_Library
{
    abstract public class Item
    {
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Title { get; private set; }

        public Item(decimal price, int stock, string title)
        {
            Price = price;
            Stock = stock;
            Title = title;
        }

        internal bool TryPurchase (int number)
        {
            this.Stock += number;
            return true;
        }

        internal bool TrySell (int number)
        {
            if (number - this.Stock >= 0)
            {
                this.Stock -= number;
                return true;
            } else
            {
                return false;
            }
        }

        public enum Catagories
        {
            History = 10,
            Thriller = 20,
            Fantasy = 30,
            Food = 40,
            Children = 50
        }
    }
}
