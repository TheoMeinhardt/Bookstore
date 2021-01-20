using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore_Library
{
    public class Book : Item
    {
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public Catagories Catagory { get; set; }

        public Book(decimal price, int stock, string title, string author, string isbn, int catagory) : base (price, stock, title)
        {
            Author = author;
            ISBN = isbn;
            Catagory = (Catagories)catagory;
        }

        public override string ToString()
        {
            return $"Book: {this.Title} ({this.Author}, {this.Catagory} ({(int)this.Catagory}))";
        }
    }
}
