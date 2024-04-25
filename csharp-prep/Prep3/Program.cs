using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 100);
        Console.WriteLine($"the magic number is {magicNumber}");
        int guess = 0;
        
        while(guess != magicNumber)
        {
            Console.WriteLine("What is your guess for the magic number?");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
                Console.WriteLine("Higher");
            else if (guess > magicNumber){
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } ;



    }
}