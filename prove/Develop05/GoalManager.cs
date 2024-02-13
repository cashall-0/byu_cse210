public class GoalManager
{
    public static List<Goal> _goals;
    public static int _score;

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;

    }
    public void Start(){
        bool play = true;
        while(play){
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:\n   1. Create New Goal \n   2. List Goals \n   3. Save Goals \n   4. Load Goals \n   5. Record Event \n   6. Quit");
            int pickedActivity = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (pickedActivity)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetail();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    play = false;
                    break;
            }
        }

    }
    public void DisplayPlayerInfo(){
        Console.WriteLine("Your Current Score is  "+ _score +"\n");
    }
    public void ListGoalNames(){
        Console.WriteLine("\n1. Simple goals");
        Console.WriteLine("2. Eternal goals");
        Console.WriteLine("3. Checklist goals");
    }
    public void ListGoalDetail(){
        if(_goals.Count()>0){
        int count  = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(count + ". " + goal.GetDetailString(goal.IsComplete()));
            count++;
        }}else{
            Console.WriteLine("No goals yet!!");
        }

    }
    public void CreateGoal(){
        Console.Write("what type of Goal do you want to create? ");
        ListGoalNames();
        int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("This is a simple Goal ");
            Console.WriteLine("What is the name of your goal? ");
            string userGoalName = Console.ReadLine();
            Console.WriteLine("Enter a short description of your goal: ");
            string userGoalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of point associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
        if(choice == 1 ){
            Goal simpleGoal = new SimpleGoal(userGoalName,userGoalDescription,points);
            _goals.Add(simpleGoal);

        }else if(choice == 2){
            Goal eternalGoal = new EternalGoal(userGoalName,userGoalDescription,points);
            _goals.Add(eternalGoal);
        }
        else if(choice == 3){
            Console.WriteLine("How many times does this goal needs to be accomplished before a bonus? ");
                int bonusCheck = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus? ");
                int bonus = int.Parse(Console.ReadLine());
            Goal checkListGoal = new ChecklistGoal(userGoalName, userGoalDescription, points,bonusCheck,bonus);
            _goals.Add(checkListGoal);
        }
    }
    public void RecordEvent(){
        Console.WriteLine("Enter event that you wish to record: ");
        ListGoalDetail();
        int toBeRecoreded = int.Parse(Console.ReadLine());
        _goals[toBeRecoreded-1].RecordEvent();
    }
    public void SaveGoals(){
        // string fileName = "myFile.txt";
        Console.WriteLine("Enter file name to save (e.g \"sample.txt\"): ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"score: {_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
            
}

    }
    public void LoadGoals(){
        _goals = new List<Goal>();
        _score = 0;
        // string filename = "myFile.txt";
        Console.WriteLine("Enter file name to load from (e.g \"sample.txt\"): ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");
            if(parts.Count() < 3){
                _score = int.Parse(parts[1]);
            }else{
                // string fGoalType = parts[1];
                string fShortName = parts[3];
                string fDescription = parts[5];
                string fPoints = parts[7];
                if(parts.Count() < 12){
                    string fIscomplete = parts[9];
                    SimpleGoal simpleGoal = new SimpleGoal(fShortName,fDescription,int.Parse(fPoints));
                    simpleGoal._isComplete=true;
                    _goals.Add(simpleGoal);
                }else if(parts.Count() < 14){
                    string fTurns = parts[11];
                    EternalGoal eternalGoal = new EternalGoal(fShortName,fDescription,int.Parse(fPoints));
                    eternalGoal.SetTurns(int.Parse(fTurns));
                    _goals.Add(eternalGoal);

                }else if(parts.Count()< 16){
                    string fBonus = parts[9];
                    string fCompleted = parts[11];
                    string fTarget = parts[13];
                    ChecklistGoal checklistGoal = new ChecklistGoal(fShortName,fDescription,int.Parse(fPoints), int.Parse(fTarget), int.Parse(fBonus));
                    checklistGoal.SetAmountCompleted(int.Parse(fCompleted));
                    _goals.Add(checklistGoal);

                }
            }


            
            
        }

    }
}