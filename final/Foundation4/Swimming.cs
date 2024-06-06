using System;
using System.Globalization;
using System.IO.Pipes;

public class Swimming: Activity
{
    private int _numberOfLaps;
    public Swimming(){
        _numberOfLaps = 0;
        _date = "";
        _minutes = 0;
    }
    public override string  GetActivitySummary(){
        return $"{_date} Swimming ({_minutes}) minutes - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
    public override double GetDistance(){
       var distance = Math.Round(_numberOfLaps * 50 / 1000 * 0.62, 3);
        return distance;
    }
    public override double GetSpeed() {
        var speed = Math.Round(60/GetPace(), 3);
        return speed;
    }
    public override double GetPace(){
        var pace = Math.Round(_minutes/GetDistance(),3);
        return pace;
    }
    public int SetNumberOfLaps(int numberOfLaps){
        return _numberOfLaps = numberOfLaps;
    }
    public string SetDate(string date){
        return _date = date;
    }
    public double SetMinutes(double minutes){
        return _minutes = minutes;
    }
}