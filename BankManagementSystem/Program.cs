using System;

namespace BankManagementSystem
{
    public class BankSystem
    {
        public class Bank
        {
            public string name { get; set; }
            public double account_no { get; set; }
            public float amount { get; set; }
            public float balance { get; set; }
            public int chioce { get; set; }

            public void GetDeatials()
            {
                Console.Write("Enter your Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Your Account Number: ");
                account_no = double.Parse(Console.ReadLine());

                Console.Write("Enter Account Balance: ");
                balance = float.Parse(Console.ReadLine());

                Console.Write("Enter how much amount you want to do operation: ");
                amount = float.Parse(Console.ReadLine());

                Console.Write("Enter either want to deposit or withdraw option 1]Deposit 2]Withdraw: ");
                chioce = int.Parse(Console.ReadLine());

                if (chioce == 1)
                {
                    Deposit();
                }
                else if (chioce == 2)
                {
                    Withdraw();
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

            public void Deposit()
            {
                float newBalance;
                newBalance = balance + amount;
                Console.WriteLine($"{amount} is credited into {account_no} and new balance is {newBalance}");
            }

            public void Withdraw()
            {
                float newBalance;
                newBalance = balance - amount;
                if (newBalance < 0)
                {
                    Console.WriteLine("Your amount to withdraw from account is not more than account balance");
                }
                else
                {
                    Console.WriteLine($"{amount} is credited into {account_no} and new balance is {newBalance}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Management System");
            Console.WriteLine("--------------------------------------");

            bool continueProgram = true;

            while (continueProgram)
            {
                Bank user=new Bank();
                user.GetDeatials();
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Do you want to continue? (yes/no)");
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice != "yes")
                {
                    continueProgram = false;
                    Console.WriteLine("Exiting the Bank Management System. Thank you!");
                }
            }
        }
    }
}
