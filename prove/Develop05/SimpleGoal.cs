using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class SimpleGoal: Goal
{
    bool _isComplete;
    public SimpleGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
        _isComplete = false;
        _checkBox = "[ ]";
    }
    public SimpleGoal CreateSimpleGoal(string shortName, string description, int points, bool isComplete){
        var goal = new SimpleGoal();
        goal.SetShortName(shortName);
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
    public bool SetIsComplete(bool isComplete){
        return _isComplete = isComplete;
    }
    public bool GetIsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(Goal goal)
    {
        return $"{goal.GetCheckBox()} {goal.GetShortName()} ({goal.GetDescription()})";
    }

}