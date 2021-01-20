using Bookstore_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(14.99m, 5, "The Mafia Exchange", "Steve Berry", "FBDKSVBDSJKLFBD", 20);
            Newspaper n = new Newspaper(3.99m, 1, "Der Standart", new DateTime(2020, 10, 20));
            AudioBook a = new AudioBook(7.99m, 1, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "GKFLSGGHFDL", 536, 30);
            
            Console.WriteLine(b.ToString());
            Console.WriteLine(n.ToString());
            Console.WriteLine(a.ToString());

            Console.ReadKey();
        }
    }
}
