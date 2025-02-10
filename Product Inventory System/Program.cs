using System;

namespace Product_Inventory_System
{
    public class Product : ProductData
    {
        public int Choice { get; set; }

        public void GetData()
        {
            Console.WriteLine("Enter what operation to be performed: ");
            Console.WriteLine("1] Add Item");
            Console.WriteLine("2] Update Item");
            Console.WriteLine("3] Display Item based on your choice");
            Choice = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Product p = new Product();
            p.PrintData();  
            p.GetData();

            if (p.Choice == 1)
            {
                ProductMethods.AddItem a = new ProductMethods.AddItem();
                a.GetData();
            }
            else if (p.Choice == 2)
            {
                ProductMethods.UpdateItem u = new ProductMethods.UpdateItem();
                u.UpdateData();
            }
            else if (p.Choice == 3)
            {
                ProductMethods.DisplayItem d = new ProductMethods.DisplayItem();
                d.ShowData();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
