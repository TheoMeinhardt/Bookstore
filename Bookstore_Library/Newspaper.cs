using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore_Library
{
    sealed public class Newspaper : Item
    {
        public DateTime DateOfIssue { get; private set; }

        public Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) : base (price, stock, title)
        {
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Newspaper: {this.Title} ({DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year})";
        }
    }
}
