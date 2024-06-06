using System;

public class Activity
{
    protected string _date;
    protected double _minutes;
    public Activity(){
        _date = "";
        _minutes = 0;
    }

    public virtual string GetActivitySummary(){
        return "";
    }
    public virtual double GetDistance(){
        return 0;
    }
    public virtual double GetSpeed(){
        return 0;
    }
    public virtual double GetPace(){
        return 0;
    }
}