using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public long ISBN { get; set; }

        public void GetData()
        {
            Console.Write("Enter book title : ");
            Title = Console.ReadLine();
            Console.Write($"Enter {Title} Author name : ");
            Author = Console.ReadLine();
            Console.Write($"Enter {Title} ISBN number : ");
            ISBN =long.Parse(Console.ReadLine()) ;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }

}
