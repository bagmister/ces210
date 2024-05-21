using System;
using System.Diagnostics;

class ReflectionActivity: Activity
{
    private List<string> _questions;
    private List<string> _prompts;
   public ReflectionActivity(){
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _duration = 0;
   }
   public void Run(){
        _questions = [
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _prompts = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        DateTime startTime = DateTime.Now;
        DisplayStartingMessage();
        DateTime endTime = startTime.AddSeconds(_duration);
        DisplayQuestions();
        Console.WriteLine("When you have something in mind, Press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder the following questions as they relate to this experience.");
        DisplayCountDown(5);
        do{
            DisplayPrompt();
        }
        while(DateTime.Now < endTime);  

        DisplayEndingMessage();
   }
   public string GetRandomPrompt(int index){
        return _prompts.ElementAt(index);
   }

    public string GetRandomQuestion(int index){
        return _questions.ElementAt(index);
    }
    public void DisplayPrompt(){
        Random random = new Random();
        var index = random.Next(0,9);
        var prompt = GetRandomPrompt(index);
        Console.WriteLine(prompt);
        DisplaySpinner(6);
    }
    public void DisplayQuestions(){
        Random random = new Random();
        var index = random.Next(0,4);
        var question = GetRandomQuestion(index);
        Console.WriteLine(question);
    }

}
