using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal (){
        _shortName = "";
        _description = "";
        _points = 0;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString(){
        return "something";
    }
    public abstract string GetStringRepresentation();
}