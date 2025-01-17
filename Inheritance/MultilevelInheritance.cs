using System;
using static SingleInheritance.SingleInheritance;


namespace Inheritance
{
    public class MultilevelInheritance
    {
        public class Student
        {
            public string name { get; set; }
            public int id { get; set; }
            public float percentage { get; set; }
        }
        public class StudentDetails:Student
        {

            public void GetData()
            {
                Console.Write("Enter the student name:");
                name = Console.ReadLine();
                Console.Write($"Enter roll no of  {name}:");
                id = int.Parse(Console.ReadLine());
                Console.Write($"Enter percentage of {name}:");
                percentage = float.Parse(Console.ReadLine());

            }
        }
        public class Marks : StudentDetails
        {
            public void Check()
            {
                if (percentage >= 90)
                {
                    Console.WriteLine($"{name} Grade is A+ ");
                }
                else if (percentage <= 80)
                {
                    Console.WriteLine($"{name} Grade is A ");
                }
                else if (percentage <= 70)
                {
                    Console.WriteLine($"{name} Grade is B+ ");
                }
                else if (percentage <= 60)
                {
                    Console.WriteLine($"{name} Grade is B ");
                }
                else
                {
                    Console.WriteLine($"{name} Grade is C your are not eligible ");
                }
            }
        }

    }
}
