using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IPayementSystem
    {
        public void ProcessPayment();
       
        public void GetData();
        public double amount {  get; set; }
    }
   
    public class OnlinePayment : IPayementSystem
    {
        public double amount { get; set; }
        public void GetData()
        {
            Console.Write("Enter amount to be creadit :");
             amount= double.Parse(Console.ReadLine());
        }
        public void ProcessPayment()
        {
           
            Console.WriteLine($"Processing  Card Payment of ${amount}");
            
        }
        
    }
    public class CashPayment : IPayementSystem
    {
        public double amount { get; set; }
        public void GetData()
        {
            Console.Write("Enter amount to be creadit :");
            amount = double.Parse(Console.ReadLine());
        }
        public void ProcessPayment()
        {

            Console.WriteLine($"Processing  Cash Payment of ${amount}");

        }
       
    }
   
    public class ServiceType
    {
        public int chice { get; set; }
        public void GetData()
        {
            Console.Write("Do you want to proceed with Online or Cash Payment :");
            chice = int.Parse(Console.ReadLine());
        }
       
    }
}
