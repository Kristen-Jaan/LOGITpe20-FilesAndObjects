using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        public class Item
        {
            string name;
            int price;

            public Item(string _name, int _price)
            {
                name = _name;
                price = _price;
            }

            public string Name { get { return name; } }

            public int Price { get { return price; } }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me");
            WriteShoppingList();
        }   

        public static void WriteShoppingList()
        {
            List<string> shoppingList = new List<string>();
            for(int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Enter item:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter price:");
                string price = Console.ReadLine();

                string line = $"{item}/{price}";
                shoppingList.Add(line); //add a line to the shoppingList list

            }

            string filePath = @"C:\Users\opilane\Samples";
            string fileName = $"shoppingList.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), shoppingList);
        }
    }
}
