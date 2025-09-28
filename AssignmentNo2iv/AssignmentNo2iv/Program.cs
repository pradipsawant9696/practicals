using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo2iv
{
    class Item
    {
        private string[] itemName;

        // Constructor to initialize the array
        public Item(int size)
        {
            itemName = new string[size];
        }

        // Indexer to access elements like an array
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < itemName.Length)
                    return itemName[index];
                else
                    return "Invalid Index";
            }
            set
            {
                if (index >= 0 && index < itemName.Length)
                    itemName[index] = value;
            }
        }

        // Method to display all items
        public void DisplayItems()
        {
            Console.WriteLine("\n--- Items List ---");
            for (int i = 0; i < itemName.Length; i++)
            {
                Console.WriteLine($"Item[{i}]: {itemName[i]}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int size = int.Parse(Console.ReadLine());

            Item items = new Item(size);

            // Accept items using indexer
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter name for item {i}: ");
                items[i] = Console.ReadLine();
            }

            // Display items using indexer
            items.DisplayItems();
        }
    }
}
