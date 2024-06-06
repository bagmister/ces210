using System;

public class Cycling: Activity
{
    private double _speed;
    public Cycling(){
        _speed = 0;
        _date = "";
        _minutes = 0;
    }
    public override string  GetActivitySummary(){
        return $"{_date} Cycling ({_minutes}) minutes - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile.";
    }
    public override double GetDistance(){
        return Math.Round(GetSpeed() * _minutes, 3);
    }
    public override double GetSpeed() {
        return _speed;
    }
    public override double GetPace(){
        return Math.Round(60/GetSpeed(), 3);
    }
    public string SetDate(string date){
        return _date = date;
    }
    public double SetMinutes(double minutes){
        return _minutes = minutes;
    }
    public double SetSpeed(double speed){
        return _speed = speed;
    }
}