using System;

namespace StudentGradesSystem
{
    internal class Program
    {
        public class StudentDetails
        {
            // Properties
            public string StudentName { get; set; }
            public string StudentSurname { get; set; }
            public int Rollno { get; set; }
            public int Age { get; set; }
            public float TotalMarks { get; set; }

        
            public void GetStudentDetails()
            {
                Console.Write("Enter Student Name:");
                StudentName = Console.ReadLine();

                Console.Write("Enter Student Surname:");
                StudentSurname = Console.ReadLine();

                Console.Write("Enter Roll Number:");
                Rollno = int.Parse(Console.ReadLine());

                Console.Write("Enter Age:");
                Age = int.Parse(Console.ReadLine());

                Console.Write("Enter Total Marks:");
                TotalMarks = float.Parse(Console.ReadLine());
            }

         
            public void Calculate(float marks)
            {
                if (marks >= 90)
                {
                    Console.WriteLine($"{StudentName} Grade is  A+ ");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine($"{StudentName} Grade is A ");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine($"{StudentName} Grade is  B+ ");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine($"{StudentName} Grade is B");
                }
                else
                {
                    Console.WriteLine($"{StudentName} Need to work hard");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade System");
            Console.WriteLine("Enter how many student details you want to enter ?");
            int n = int.Parse(Console.ReadLine());
            StudentDetails[] std = new StudentDetails[n];
           for (int i = 0; i < n; i++)
            {
                std[i]=new StudentDetails();
                Console.WriteLine("-----------STUDENT-----------");
                Console.WriteLine();
                std[i].GetStudentDetails();
                std[i].Calculate(std[i].TotalMarks);
                Console.WriteLine();
            }
        }
    }
}
