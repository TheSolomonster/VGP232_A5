using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            Inventory inventory = new Inventory(3);
            inventory.AddItem(new Item("Big Sword", 5, ItemGroup.Equipment));
            inventory.AddItem(new Item("Elegent key", 1, ItemGroup.Key));
            if(inventory.ListAllItems().Count == 2)
            {
                Console.WriteLine("It works!");
            }
            else
            {
                Console.WriteLine("It doesn't!");
            }
        }
    }
}
