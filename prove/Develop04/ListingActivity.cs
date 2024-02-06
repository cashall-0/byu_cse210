using System.Collections;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity():base(){
        this._prompts = new List<string>{"Who are people that you appreciate", "What are personal strengths of yours", "Who are people that you have helped this week", "When have you felt the Holy Ghost this month", "Who are some of your personal heroes"};
    }
    public void Run(){
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetName("Listing Activity");
        DisplayStartingMessage();
        Console.Clear();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt(){
        Random random = new Random();
        List<string> myList = GetPromts();
        string prompt =  myList[random.Next(0,myList.Count-1)];
        Console.WriteLine(prompt);
        _count++;
    }
    public List<string> GetListFromUser(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        List<string> newList = new List<string>();
        while(DateTime.Now < futureTime){
            string userAnswer = Console.ReadLine();
            newList.Add(userAnswer);
        }

        return newList;
    }
    public int GetCount(){
        return _count;
    }
    public void SetCount(int count){
        this._count = count;
    }
    public List<string> GetPromts(){
        return this._prompts;
    }
    public void SetPrompts(List<string> prompts){
        this._prompts = prompts;
    }
}