using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("App version 1.0");

        bool application = true;
        List<string> list = new List<string>();

        while (application)
        {
            Console.WriteLine("Type 'add' to add to todo list, type 'show' to show todo list, type 'quit' to quit app");
            string input = Console.ReadLine();

            if (input.ToLower() == "add")
            {
                Console.WriteLine("Type what you want to add to the todo list");
                string inputToAdd = Console.ReadLine();
                list.Add(inputToAdd);
                Console.WriteLine("Item added to the list.");
            }
            else if (input.ToLower() == "show")
            {
                Console.WriteLine("Your todo list:");
                foreach (string item in list)
                {
                    Console.WriteLine("- " + item);
                }
            }
            else if (input.ToLower() == "quit")
            {
                application = false;
            }
            else
            {
                Console.WriteLine("Invalid command. Please type 'add', 'show', or 'quit'.");
            }
        }

        Console.WriteLine("Application closed.");
    }
}
