using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Word word= new Word("");
        Console.WriteLine("What scripture would you like to memorize?");
        Console.WriteLine("Enter 1 for Proverbs 3:5-6");
        Console.WriteLine("Enter 2 for John 3:16");
        var scriptureChoice = int.Parse(Console.ReadLine());
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        var choice = Console.ReadLine();
        Reference reference = new Reference("",0,0);
        do{
            if (scriptureChoice == 1){
                Console.WriteLine("You have chosen Proverbs 3:5-6");
                reference = new Reference("Proverbs", 3, 5, 6);

            }
            else if (scriptureChoice == 2){
                Console.WriteLine("You have chosen John 3:16");
                reference = new Reference("John", 3, 16);
            }
            else
            {
                Console.WriteLine("Invalid Choice. Will use John 3:16");
                reference = new Reference("John", 3, 16);
            }
            Console.Clear();
            Scripture scripture = new Scripture(reference, reference.GetDisplayText(scriptureChoice));
            Console.WriteLine($"{reference.GetDisplayReference()} {reference.GetDisplayText(scriptureChoice)}");
            choice = Console.ReadLine();


        } 
        while(choice.ToLower() != "quit");
    }
}