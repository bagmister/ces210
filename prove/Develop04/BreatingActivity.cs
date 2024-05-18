using System;

public class BreathingActivity: Activity
{
   public BreathingActivity(){
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
   }
   public void Run(){
    _name = "Breathing Activity";
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);
    DisplayStartingMessage();
    do{
        Console.WriteLine("Breathe in.....");
        DisplayCountDown(4);
        Console.WriteLine("Breathe out.....");
        DisplayCountDown(4);
    }
    while(DateTime.Now < endTime);

    DisplayEndingMessage();
   }
    
}