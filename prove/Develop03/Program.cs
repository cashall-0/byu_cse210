using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // Truly, I say to you, among those born of women there has arisen no one greater than John the Baptist. Yet the one who is least in the kingdom of heaven is greater than he

        Reference reference = new Reference("Mattew",11,11);
        Scripture scripture = new Scripture(reference,"Truly, I say to you.");
        scripture.GetDisplayText();
        bool quitP = false;
        int count = 0;
        while(!quitP){
            count++;
            Console.WriteLine(scripture.GetDisplayText());
            string action = Console.ReadLine();
            if(scripture.IsCompletelyHidden() || action == "quit"){
                quitP = true;
            }else{
                scripture.HideRandomWords(count);
                Console.Clear();
            }
        }


        

    }
}