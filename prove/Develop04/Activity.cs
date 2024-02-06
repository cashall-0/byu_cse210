using System.Xml.Schema;

public class Activity
{
    private String _name;
    private String _description;
    private int _duration;

    public Activity(string name, string description,int duration){
        this._name = name;
        this._description = description;
        this._duration = duration;
    }
    public Activity(){

    }
    public void DisplayStartingMessage(){
        Console.WriteLine("Welcome to the "+ _name +"\n");
        Console.WriteLine(_description);
        Console.Write("\nWhat duration in seconds do you want to run the session?  ");
        string number = Console.ReadLine();
        int userDuration  = int.Parse(number);
        SetDuration(userDuration);
        Console.Clear();
        Console.WriteLine("Prepare to begin!!!\n");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("Good job");
        ShowSpinner(5);
        Console.WriteLine($"You just completed the " + _name + " This Activity lasted for "+ _duration + " seconds");
        ShowSpinner(5);
        
    }
    public void ShowSpinner(int seconds){
        List<string> _animationArms = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        foreach (string arm in _animationArms)
        {
            Console.Write(arm);
            Thread.Sleep(seconds*1000/8);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds){
        for(int c = 5;c>0;c--){
        Console.Write(c);
        Thread.Sleep(seconds*1000);
        Console.Write("\b \b");
        };
    }

    public String GetName(){
        return this._name;
    }
    public String GetDescription(){
        return this._description;
    }
    public int GetDuration(){
        return this._duration;
    }
    public void SetName(string name){
        this._name = name;
    }
    public void SetDescription(string description){
        this._description = description;
    }
    public void SetDuration(int duration){
        this._duration = duration;
    }

}