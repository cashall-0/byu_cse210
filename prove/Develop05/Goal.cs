using System.Runtime.InteropServices;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points){
        _shortName  = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString(bool isDone){
        string done = isDone? "{x}":"{ }";
        return $"{done}  {_shortName} {_description}";  
    }
    public abstract string GetStringRepresentation();

    public void SetShortName(string shortName){
        this._shortName = shortName;
    }
    public void SetDescription(string description){
        this._description = description;
    }
    public void SetPoints(int points){
        this._points = points;
    }
    public string GetShortName(){
        return this._shortName;
    }
    public string GetDescription(){
        return this._description;
    }
    public int GetPoints(){
        return this._points;
    }
}
