using System;
namespace SingleInheritance
{
    public class SingleInheritance
    {
       
        public class FruitDetail
        {
            public string f_name { get; set; }
            public void GetData()
            {
                UserInput userInput = new UserInput();
                Console.WriteLine("Enter the name of the fruit:");
                userInput.f_name = Console.ReadLine();

            }
        }


        public class UserInput : FruitDetail
        {
            public void PrintData()
            {
                Console.WriteLine($"You have selected {f_name}");
            }
        }
        

       
    }

}


