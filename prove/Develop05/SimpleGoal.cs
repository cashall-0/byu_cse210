public class SimpleGoal : Goal
{
    public bool _isComplete;
    public SimpleGoal(string shortName, string description, int points):base(shortName,description,points){
        this._isComplete = false;
    }
    public override void RecordEvent(){
        _isComplete = true;
        GoalManager._score += GetPoints();
        Console.WriteLine($"You now have {GetPoints()}");
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return $"Type: Simple Goal: ShortName: {GetShortName()}: Description: {GetDescription()}: Points: {GetPoints()}: CompleteStatus: {_isComplete}";
    }
    public void SetIsComplete(bool isComplete){
        _isComplete = isComplete;
    }
    public bool GetIsComplete(){
        return _isComplete;
    }
    
}