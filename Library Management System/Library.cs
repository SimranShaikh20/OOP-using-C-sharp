using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public class Library
    {
        private List<Books> b;

        public Library()
        {
            b = new List<Books>();
        }

        public void AddBook(Books book)
        {
            b.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        public void RemoveBook(string title)
        {
            Books bookToRemove = b.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                b.Remove(bookToRemove);
                Console.WriteLine($"Book '{title}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found in the library.");
            }
        }
        public void ListBooks()
        {
            if (b.Count > 0)
            {
                Console.WriteLine("Books in the library:");
                foreach (var book in b)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books in the library.");
            }
        }
    }
}
