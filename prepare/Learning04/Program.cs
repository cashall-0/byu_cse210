using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        WritingAssingment writingAssingment = new WritingAssingment("The cause of World war 2","Mary Waters", "European History");
        Console.WriteLine(writingAssingment.GetSummary());
        Console.WriteLine(writingAssingment.getWritingInformation());
    }
}