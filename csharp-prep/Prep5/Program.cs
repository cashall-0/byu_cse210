using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        void DisplayWelcome(){
        Console.WriteLine("Welcome to the program");
    }

    string PromptUserName(){
        Console.Write("Enter user's name: ");
        string name = Console.ReadLine();
        return name;
    }
    int PromptUserNumber(){
        Console.Write("Enter user's favorite number: ");
        string number = Console.ReadLine();
        return int.Parse(number);
    }
    int SquareNumber(int num){
        return num * num;
    }
    void DisplayResult(string name, int num){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }

    DisplayWelcome();
    DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
        
    }
}