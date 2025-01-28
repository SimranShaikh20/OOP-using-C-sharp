using System;

namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Delegates Example!");
            Console.WriteLine("Enter which example do you want to see:");
            Console.WriteLine("1] Basics of Delegates");
            Console.WriteLine("2] Delegate with Anonymous Methods");
            Console.WriteLine("3] Delegate with Lambda Expression");
            Console.WriteLine("4] Delegate as a Parameter");
            Console.WriteLine("5] Multicast Delegates");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                MathOperation op1 = SimpleDelegat.Add;
                Console.WriteLine("Addition: " + op1(10, 8));

                MathOperation op2 = SimpleDelegat.Sub;
                Console.WriteLine("Subtraction: " + op2(16, 8));
            }
        }
    }
}
