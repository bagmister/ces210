using System;

class Program
{
    static void Main(string[] args)
    {
        var swimming = new Swimming();
        var running = new Running();
        var cycling = new Cycling();
        var activities = new List<string>();

        swimming.SetDate("03/15/24");
        swimming.SetMinutes(20);
        swimming.SetNumberOfLaps(20);
        activities.Add(swimming.GetActivitySummary());

        running.SetDate("03/16/24");
        running.SetMinutes(150);
        running.SetDistance(40);
        activities.Add(running.GetActivitySummary());

        cycling.SetDate("03/17/24");
        cycling.SetMinutes(40);
        cycling.SetSpeed(10);
        activities.Add(cycling.GetActivitySummary());
        foreach (string activity in activities){
            Console.WriteLine(activity);
        }
    }
}