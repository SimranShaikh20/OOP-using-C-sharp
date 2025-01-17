using static Polymerphism.VehicalSystem;

namespace Polymerphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Polymerphim Concept");
            Console.WriteLine("Enter chice what like to know  ");
            Console.WriteLine("1]Method Overriding");
            Console.Write("2]Method  Overloading :");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Truck myTruck = new Truck();
                myTruck.Sound();

                Truck myCar = new Car();
                myCar.Sound();

                Truck myMotorCycle = new MotorCycle();
                myMotorCycle.Sound();

            }
            if (choice == 2)
            {
                EmployeeBonus.Bonus b = new EmployeeBonus.Bonus();
                int baseSalary = 50000;
                double bonus1 = b.CalculateBonus(baseSalary);
                Console.WriteLine($"10% Bonus: {bonus1}");
                double percentage = 15;
                double bonus2 =b.CalculateBonus(baseSalary, percentage);
                Console.WriteLine($"Custom Bonus ({percentage}%): {bonus2}");
                int yearsOfService = 5;
                double bonus3 = b.CalculateBonus(baseSalary, yearsOfService);

            }

        }
    }
}
