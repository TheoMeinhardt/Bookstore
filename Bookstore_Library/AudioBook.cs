using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore_Library
{
    public sealed class AudioBook : Book
    {
        public int Duration { get; private set; }

        public AudioBook(decimal price, int stock, string title, string author, string isbn, int duration, int catagory) : base (price, stock, title, author, isbn, catagory)
        {
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Audiobook: {this.Title} ({this.Author}, {this.Duration} minutes, {this.Catagory} ({(int)this.Catagory}))";
        }
    }
}
