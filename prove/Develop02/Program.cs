using System;
using System.Diagnostics;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        bool _quit = false;
        Journal journal = new Journal();
        while(!_quit){
            Console.WriteLine("please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string userInput = Console.ReadLine();
            int userValue = int.Parse(userInput);


            if(userValue == 1){
                PromptGenerator promptGenerator = new PromptGenerator();
                string question = promptGenerator.GetRandomPrompt();
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                Entry entry = new Entry();
                entry._date =theCurrentTime.ToShortDateString();
                entry._promptText = question;
                entry._entryText = answer;
                journal.AddEntry(entry);
            }else if(userValue == 2){
                journal.DisplayAll();

            }else if(userValue == 3){
                Console.WriteLine("What is the file name? ");
                string fName = Console.ReadLine();
                journal.LoadFromFile(fName);
            }else if(userValue == 4){
                Console.WriteLine("Enter new file name? ");
                string fName = Console.ReadLine();
                journal.SaveToFile(fName);
            }else if(userValue == 5){
                _quit = true;
            }else{
                Console.WriteLine("Invalid request");
            }
        }
    }
}