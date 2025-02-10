using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Product_Inventory_System
{
    public class ProductMethods
    {
        private static List<AddItem> p = new List<AddItem>();
        public class AddItem
        {
            public int price { get; set; }
            public string name { get; set; }
            
            public void GetData()
            {
                Console.Write("Enter item name to add: ");
                name = Console.ReadLine();
                Console.Write($"Enter price of {name} : ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Item Added");
                p.Add(new AddItem { name = name, price = price });
                Console.WriteLine("---------------------");
            }
        }

        public class UpdateItem : AddItem
        {
            public int new_price { get; set; }

            public void UpdateData()
                  
            {
                Console.WriteLine("Enter new price of item: ");
                new_price = int.Parse(Console.ReadLine());
                price = new_price;
                AddItem itemToUpdate = p.Find(p => p.name.Equals(name, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Item price updated successfully");
            }
        }

        public class DisplayItem : UpdateItem
        {
            public void ShowData()
            {
                Console.Write("Enter the name of the item to display: ");
                string itemName = Console.ReadLine();

                // Search for the item by name
                var product = p.Find(p => p.name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                {
                    // Item found, display its details
                    Console.WriteLine($"Item Name: {product.name}, Price: {product.price}");
                    Console.WriteLine("--------End of Inventory-----");
                }
                else
                {
                    // Item not found
                    Console.WriteLine("Item not found in the inventory.");
                }
            }

        }
    }
}
