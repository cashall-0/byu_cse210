using System;

class Program
{
    static void Main(string[] args)
    {
        bool inSession = true;
        while (inSession)
        {
            Console.WriteLine("Menu Options: \n     1. Start breathing activity\n     2. Start reflecting activity\n     3. Start listing activity\n     4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userOption = Console.ReadLine();
            int userNum = int.Parse(userOption);
            Console.Clear();
            switch (userNum)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    Reflectingactivity reflectingactivity = new Reflectingactivity();
                    reflectingactivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 4:
                    inSession = false;
                    break;
            }
            Thread.Sleep(3000);
        }
    }
}