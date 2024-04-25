using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Greetings, Enter your grade to see what the letter representation is. Example 80.");
        int grade = int.Parse(Console.ReadLine());
        Console.WriteLine($"You entered {grade}.");
        if (grade >= 90)
        {
            Console.WriteLine("Your leter grade is an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your leter grade is an B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your leter grade is an C");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("Your leter grade is an D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your leter grade is an F");
        }
    }
}