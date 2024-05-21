using System;

public class BreathingActivity: Activity
{
   public BreathingActivity(){
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    _duration = 0;
   }
   public void Run(){
    DateTime startTime = DateTime.Now;
    DisplayStartingMessage();
    DateTime endTime = startTime.AddSeconds(_duration);
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