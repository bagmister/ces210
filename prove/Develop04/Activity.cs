using System;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Activity chosen: {_name}. Executing program");
        Console.WriteLine("How long would you like the activity to run for in seconds? Enter a whole number 1 - infinite.");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preapre yourself.....");
        Thread.Sleep(1000);
        DisplaySpinner(5);
    }
    public void DisplayEndingMessage(){
        Console.WriteLine($"Good Job! Now that the {_name} activity is done. Rest and meditate on what was learned or reflected upon.");
        DisplaySpinner(5);
        Console.Clear();
    }
    public void DisplaySpinner(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("\\");
        animationString.Add("-");
        animationString.Add("/");

        int i=0;
        while(DateTime.Now < endTime){
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationString.Count){
                i = 0;
            }
        }
    }
    public void DisplayCountDown(int seconds){
        for(int i = seconds; i >= 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}