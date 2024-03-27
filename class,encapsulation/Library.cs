using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_encapsulation
{
    internal class Library
    {
        public Book[] Books = new Book[] { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length-1] = book;
        }


        public Book[] GetFilteredBooks(string genre)
        {
            return Books;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] books = { };
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice&& Books[i].Price<= maxPrice)
                {
                    Array.Resize (ref books, books.Length + 1);
                    books[Books.Length - 1] = Books[i];   
                }
            }
            return books;
        }
        public void ShowAllBooks()
        {
            
            for (int i = 0;i < Books.Length;i++)
            {
                Console.WriteLine($"Books[i].GetFullData(),{Books[i].Genre}");
            }
            
        }
    }
}
