using System;

class CheckListGoal : Goal
{
    int _amountCompleted;
    int _traget;
    int _bounus;

    public CheckListGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
    }
    public override int RecordEvent(){
        return _amountCompleted;
    }
    public override bool IsComplete(){
        return _amountCompleted == 0;
    }
    public string GetDetailsString(){
        return "";
    }
    public override string GetStringRepresentation(){
        return _amountCompleted.ToString();
    }
    public CheckListGoal CreateCheckListGoal(string name, string description, int checkListNumber,int bonusPoints){
        var goal = new CheckListGoal();

        return goal;
    }
}
