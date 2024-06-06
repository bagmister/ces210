using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _checkBox;

    public Goal (){
        _shortName = "";
        _description = "";
        _points = 0;
        _checkBox = "[ ]";
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        return "something";
    }
    public abstract string GetStringRepresentation(Goal goal);
    public string SetCheckBox(bool isComplete){
        if (isComplete != false){
            return _checkBox = "[x]";
        }
        else{
            return _checkBox = "[ ]";
        }
    }
    public string GetCheckBox(){
        return _checkBox;
    }
    public string GetShortName(){
        return _shortName;
    }
    public string SetShortName(string shortName){
        return _shortName = shortName;
    }
    public string SetDescription(string description){
        return _description = description;
    }
    public string GetDescription(){
        return _description;
    }
    public int SetPoints(int points){
        return _points = points;
    }
    public int GetPoints(){
        return _points;
    }

}