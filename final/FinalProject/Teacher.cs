public class Teacher:Person
{
    public Teacher(string _firstName, string _lastName, long _id, string _address, string _phone, string _email):base(_firstName, _lastName, _id, _address, _phone, _email, true){
        
    }
    public Teacher(string _firstName, string _lastName, string _address, string _phone, string _email):base(_firstName, _lastName, Classroom._personId, _address, _phone, _email, true){
        Classroom._personId++;
        
    }
    public override string ChangeToString()
    {
        return $"{GetFirstName()},={GetLastName()},={GetId()},={GetAddress()},={GetPhone()},={GetEmail()}";
    }

    public Classwork ScoreClassWork(Classwork classwork){
        Question question = classwork.GetQuestion();
        Console.WriteLine($"{question.GetQuestion()}\nMax score is {question.GetMaxScore()}");
        Console.WriteLine("Enter student score: ");
        int score = int.Parse(Console.ReadLine());
        classwork.SetScore(score);
        return classwork;
    }
    public void CreateQuestion(){
        Console.WriteLine("Enter your question here: ");
        string quest = Console.ReadLine();
        Console.WriteLine("Enter question max score here: ");
        int questScore = int.Parse(Console.ReadLine());
        Console.WriteLine("How many days are students allowed to do this work? ");
        int questDays = int.Parse(Console.ReadLine());
        DateTime futureDate = DateTime.Now.AddDays(questDays);
        Question question = new Question(Classroom.assingmentIdCount,quest,GetId(),questDays,questScore, futureDate);
        Classroom.assingmentIdCount++;
        Classroom.questions.Add(question);
    }
    public void DisplayStudentList(){
        foreach (Person i  in Classroom.people)
        {
            if(!i.GetIsStaff()){
                Console.WriteLine($"{i.GetId}_  {i.GetLastName} {i.GetFirstName}");
            }
        }

    }
}