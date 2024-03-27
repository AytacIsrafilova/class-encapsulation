using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_encapsulation
{
    internal class Book:Product
    {
        public string Genre;

        public Book(string genre,string name, byte no, double price,byte count):base(name,no,price,count)
        {
            this.Genre = genre;
        }

        public void ShowInfo()
        {
             
            Console.WriteLine($"{GetFullData()}\n{this.Genre}");
        }
    }
}
