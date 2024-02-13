public class EternalGoal:Goal
{
    private int _turns;
    public EternalGoal(string name, string description, int points):base(name,description,points){
        _turns = 0;
    }
    public override void RecordEvent(){
        _turns += 1;
        GoalManager._score += GetPoints();
        Console.WriteLine($"You now have {GetPoints()}");

    }
    public override bool IsComplete(){
        return false;
    }
    public override string GetStringRepresentation(){
        return $"Type: Eternal Goal: ShortName: {GetShortName()}: Description: {GetDescription()}: Points: {GetPoints()}: CompleteStatus: {IsComplete()}: Turns: {_turns}";
    }
    public int GetTurns(){
        return _turns;
    }
    public void SetTurns(int turns){
        _turns = turns;
    }
}