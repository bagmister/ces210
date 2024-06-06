using System;

public class Running: Activity
{
    private double _distance;
    public Running(){
        _date = "";
        _minutes = 0;
        _distance = 0;
    }
    public override string  GetActivitySummary(){
        return $"{_date} Running ({_minutes}) minutes - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
    public override double GetDistance(){
        return _distance;
    }
    public override double GetPace(){
        return Math.Round(GetDistance()/_minutes * 60, 3);
    }
    public override double GetSpeed() {
        return Math.Round(60/GetPace(), 3);
    }
    public string SetDate(string date){
        return _date = date;
    }
    public double SetMinutes(double minutes){
        return _minutes = minutes;
    }
    public double SetDistance(double distance){
        return _distance = distance;
    }
}