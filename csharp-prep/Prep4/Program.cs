using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberList = new List<int>();
        var numberToAdd = -1;
        while(numberToAdd != 0){
            Console.WriteLine("Enter a number");
            numberToAdd = int.Parse(Console.ReadLine());
            if (numberToAdd != 0)
            {
                numberList.Add(numberToAdd);
            }

        }
        var numberSum = numberList.Sum();
        var numberAverage = numberList.Average();
        var numbersMax = numberList.Max();
        Console.WriteLine($"The sum is : {numberSum} ");
        Console.WriteLine($"The average is : {numberAverage} ");
        Console.WriteLine($"The largest number is : {numbersMax} ");
        
    }
}