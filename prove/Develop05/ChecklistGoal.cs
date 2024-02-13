public class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name,description,points){
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent(){
        _amountCompleted++;
        GoalManager._score += GetPoints();
        if(_amountCompleted == _target){
            GoalManager._score += _bonus;
            Console.WriteLine($"You just earned a bonus of {_bonus} for completing a checklist goal.");
        }
        Console.WriteLine($"You now have {GetPoints()}");
    }
    public override bool IsComplete(){
        if(_amountCompleted == _target){
            return true;
        }
        return false;
    }
    public override string GetDetailString(bool isDone){
         string done = isDone? "{x}":"{ }";
        return $"{done}  {GetShortName()} {GetDescription()} -- Currently Completed{_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation(){
        return $"Type: Checklist Goal: ShortName: {GetShortName()}: Description: {GetDescription()}: Points: {GetPoints()}: Bonus: {_bonus}: Completed: {_amountCompleted}: Target: {_target}";
    }
    public int GetAmountCompleted(){
        return _amountCompleted;
    }
    public int GetTarget(){
        return _target;
    }
    public int GetBonus(){
        return _bonus;
    }
    public void SetAmountCompleted(int amount){
        _amountCompleted = amount;
    }
    public void SetTarget(int target){
        _target = target;
    }
    public void SetBonus(int bonus){
        _bonus = bonus;
    }
}
