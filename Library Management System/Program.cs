namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library Management System");
            Library library = new Library();

            Books book1 = new Books();
            library.AddBook(book1);
            Console.WriteLine("\nCurrent Library Collection:");
            library.ListBooks();

            library.RemoveBook("1984");

            Console.WriteLine("\nLibrary Collection After Removal:");
            library.ListBooks();
        }
    }
}
