namespace Interface
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To new Concept of C# is Interfaces ");
            ServiceType s=new ServiceType();
            s.GetData();
            if (s.chice == 1)
            {
                IPayementSystem o = new OnlinePayment();
                o.GetData();
                Console.WriteLine();
                o.ProcessPayment();
            }
            else if (s.chice == 2)
            {
                IPayementSystem c = new CashPayment();
                c.GetData();
                Console.WriteLine();
                c.ProcessPayment();
            }
            else {

                Console.WriteLine("Invalid Chioce");
                
            }

            


            

        }
    }
}
