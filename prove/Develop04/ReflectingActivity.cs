public class Reflectingactivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public Reflectingactivity():base(){
        this._prompts = new List<string>{"Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need", "Think of a time when you did something truly selfless"};
        this._questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    public void Run(){
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetName("Refection Activity");
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(3);
        DisplayQuestions(GetDuration());
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        List<string> myList = GetPromts();
        return myList[random.Next(0,myList.Count-1)];
    }
    public string GetRandomQuestion(){
        Random random = new Random();
        return _questions[random.Next(0,_questions.Count-1)];
    }
    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions(int duration){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while(DateTime.Now < futureTime){
            List<string> used = new List<string>();
            string newQuestion = GetRandomQuestion();
            while(used.Contains(newQuestion)){
                newQuestion = GetRandomQuestion();
            }
            used.Add(newQuestion);
            Console.WriteLine("\n"+newQuestion);
            ShowSpinner(5);
            Thread.Sleep(3000);
        }


    }
    public List<string> GetPromts(){
        return this._prompts;
    }
    public void SetPrompts(List<string> prompts){
        this._prompts = prompts;
    }
    public List<string> GetQuestions(){
        return this._questions;
    }
    public void SetQuestions(List<string> questions){
        this._questions = questions;
    }
}