using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class SimpleGoal: Goal
{
    public SimpleGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
        _isComplete = false;
    }
    bool _isComplete;
    public SimpleGoal CreateSimpleGoal(string shortName, string description, int points, bool isComplete){
        var goal = new SimpleGoal();
        goal.SetShorName(shortName);
        goal.SetDescription(description);
        goal.SetPoints(points);
        goal.SetIsComplete(isComplete);
        return goal;
    }
    public override int RecordEvent(){
        return 0;
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return "";

    }
    public string SetShorName(string shortName){
        return _shortName = shortName;
    }
    public string GetShorName(){
        return _shortName;
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
    public bool SetIsComplete(bool isComplete){
        return _isComplete = isComplete;
    }
    public bool GetIsComplete(){
        return _isComplete;
    }
}