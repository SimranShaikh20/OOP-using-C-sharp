using System;
using System.Linq;

namespace GenericsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello to Generics Example!");

            GeneralStoreData<string> g = new GeneralStoreData<string>();
            g.AddItem("Simran Shaikh");
            g.AddItem("John Doe");
            GeneralStoreData<int> i = new GeneralStoreData<int>();
            i.AddItem(20);
            i.AddItem(900);

            Console.WriteLine("\nAll items in the store:");

            var combined = g.GetItem().Cast<object>().Concat(i.GetItem().Cast<object>());

            foreach (var item in combined)
            {
                Console.WriteLine(item);
            }
        }
    }
}
