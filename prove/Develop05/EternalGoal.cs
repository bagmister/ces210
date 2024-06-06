using System;

class EternalGoal : Goal
{
    public EternalGoal(){
        _shortName = "";
        _description = "";
        _points = 0;
        _checkBox = "[ ]";
    }
    public override int RecordEvent(){
        return 0;
    }
    public override bool IsComplete(){
        return true;
    }
    public override string GetStringRepresentation(Goal goal){
        return _shortName;
    }
}
