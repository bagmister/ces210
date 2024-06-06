using System;
using System.Reflection.Metadata;

class CheckListGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bounus;

    public CheckListGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
        _checkBox = "[ ]";
        _target = 0;
        _bounus = 0;
    }
    public CheckListGoal CreateCheckListGoal(string shortName, string description, int points, bool isComplete, int target,int bonusPoints){
        var goal = new CheckListGoal();
        goal.SetShortName(shortName);
        goal.SetDescription(description);
        goal.SetPoints(points);
        goal.SetCheckBox(isComplete);
        goal.SetTarget(target);
        goal.SetBonusPoints(bonusPoints);
        return goal;
    }
    public override int RecordEvent(){
        return _amountCompleted;
    }
    public override bool IsComplete(){
        return _amountCompleted == 0;
    }
    public override string GetDetailsString(){
        return "";
    }
    public override string GetStringRepresentation(Goal goal){
        return _amountCompleted.ToString();
    }
    public int SetBonusPoints(int bouns){
        return _bounus = bouns;
    }
    public int GetBonusPoints(){
        return _bounus;
    }
    public int SetTarget(int target){
        return _target = target;
    }
    public int GetTarget(){
        return _target;
    }

}
