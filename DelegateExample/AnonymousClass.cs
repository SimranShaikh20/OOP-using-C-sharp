using System;

namespace DelegateExample
{
    // Define the delegate
    public delegate void Showdata(string s);

    public class AnonymousClass
    {
        public static Showdata GetMessageHandlers()
        {
            Showdata message = delegate (string name)
            {
                Console.WriteLine($"Hello {name}");
            };

            message += delegate (string name)
            {
                Console.WriteLine($"{name}, Welcome to Delegates!");
            };

            return message; 
        }
    }
}
