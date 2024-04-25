using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        
        var userName = PromptUserName();
        var userNumber = PromptUserNumber();
        var squareNumber= SquareNumber(userNumber);
        
        DisplayResult(squareNumber, userName);

        static void DisplayMessage(){
            Console.WriteLine("Welcome to the program!!");
        }
        static string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            var userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number: ");
            var userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber(int number){
            var numberSqured = number * number;
            return numberSqured;
        }
        static void DisplayResult(int squaredNumber, string userName){
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
    
}