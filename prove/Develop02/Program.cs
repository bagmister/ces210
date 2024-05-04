using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        var fileName = "Journal.csv";
        var directory = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(directory,fileName);

        Console.WriteLine("Welcome to the Journal Program!");
        var choice = 0;
        Random random= new Random();
        Journal journal= new Journal();
        PromptGenerator promptGenerator= new PromptGenerator();
        var entries = new List<string>();
        do{
            Console.WriteLine($"File path where we are writing to: {filePath}");
            Console.WriteLine("");
            Console.WriteLine("Enter what you would like to do:");        
            Console.WriteLine("1. Write:");
            Console.WriteLine("2. Display:");
            Console.WriteLine("3. Load:");
            Console.WriteLine("4. Save:");
            Console.WriteLine("5. Quit:");
            choice = int.Parse(Console.ReadLine()); 
            if (choice == 1)
            {
                journal.AddEntry(random, promptGenerator);
            }
                
                
            else if (choice == 2)
            {
                journal.DisplayAll(filePath, entries);
            }
            else if (choice == 3)
            {
                journal.LoadFromFile(filePath);
            }
            else if (choice == 4)
            {
                journal.SaveToFile(filePath,entries);
            }
            else if(choice == 5)
            {
                Console.WriteLine("You entered 5. Goodbye");

            }
            else{
                Console.WriteLine("Invalid entry or choice. Must enter a number 1-5");
            }
            Console.WriteLine();
        }
        while (choice != 5);
    }
}