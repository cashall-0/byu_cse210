using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int guessedNumber;
        int magicNumber;

        magicNumber = randomGenerator.Next(1, 100);
        bool result = false;
        int guessCount = 0;
    while(!result){
        Console.Write("What is your guess? ");
        guessedNumber = int.Parse(Console.ReadLine());
        guessCount++;
        if(guessedNumber > magicNumber){
            Console.WriteLine("Lower");
        }else if(guessedNumber < magicNumber){
            Console.WriteLine("Higher");
        }else{
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed {guessCount} times.");
            result = true;
        }
    }

    }
}