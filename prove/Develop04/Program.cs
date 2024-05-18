using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = 0;
        do{
            Console.WriteLine("Menu Options: Enter a number 1-4");
            Console.WriteLine("1. Start Breathing actiivity");
            Console.WriteLine("2. Start Reflection actiivity");
            Console.WriteLine("3. Start Listening actiivity");
            Console.WriteLine("4. quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.Run();

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if(choice == 4)
            {
                Console.WriteLine("4 has been entered. Shutting down.");
                Environment.Exit(choice);
            }
            else
            {
                Console.WriteLine("Invalid choice. Enter a number again....");
            }
        }
        while(choice != 4);  
    }
}