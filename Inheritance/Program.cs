using System;
using static Inheritance.MultilevelInheritance;
using static SingleInheritance.SingleInheritance;

namespace FruitSelectionApp
{
 
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to inheritance application");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter your choice  ");
            Console.WriteLine("1] Single Inheritance");
            Console.WriteLine("2]Mutlilevel Inheritance");
            int chioce=int.Parse(Console.ReadLine());
            if (chioce == 1)
            {
                UserInput u = new UserInput();
                u.GetData();
                u.PrintData();
            }
            else if (chioce == 2)
            {
                Marks m=new Marks();    
                m.GetData();
                m.Check();
            }

        }
    }
}
