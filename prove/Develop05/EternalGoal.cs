using System;

class EternalGoal : Goal
{
    public EternalGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
        _checkBox = "[ ]";    
    }
    public EternalGoal CreateEternalGoal(string shortName, string description, int points, bool isComplete){
        var goal = new EternalGoal();
        goal.SetShortName(shortName);
        goal.SetDescription(description);
        goal.SetPoints(points);
        goal.SetCheckBox(isComplete);
        return goal;
    }
    public override int RecordEvent(){
        return 0;
    }
    public override bool IsComplete(){
        return false;
    }
    public override string GetStringRepresentation(Goal goal){
        return _shortName;
    }
}
