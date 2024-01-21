using System.Runtime.Serialization;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the first thing you did today?", "What was the worst experience you had today?", "Describe the weather impact on your day today?"};
    public string GetRandomPrompt(){
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        return randomPrompt;
    }
}