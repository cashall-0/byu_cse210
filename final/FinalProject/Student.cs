public class Student : Person
{
    private string _regNo;
    private List<Classwork> classworks;
    
    public Student(string _firstName, string _lastName, long _id, string _address, string _phone, string _email,  string _regNo):base(_firstName, _lastName, _id, _address, _phone, _email, false){
        classworks = new List<Classwork>();
        foreach (Classwork item in Classroom.classworks)
        {
            if(item.GetAssId()==_regNo){
                classworks.Add(item);
            
            }
        }
    }
    public Student(string _firstName, string _lastName, string _address, string _phone, string _email,  string _regNo):base(_firstName, _lastName, Classroom._personId, _address, _phone, _email, false){
        classworks = new List<Classwork>();
        Classroom._personId++;
        foreach (Classwork item in Classroom.classworks)
        {
            if(item.GetAssId()==_regNo){
                classworks.Add(item);
            
            }
        }
    }
    public override string ChangeToString()
    {
        return $"{GetFirstName()},={GetLastName()},={GetId()},={GetAddress()},={GetPhone()},={GetEmail()},={_regNo}";
    }
    public void SubmitAssingment(Classwork assingmnent){
        Classroom.classworks.Add(assingmnent);
    }
    public void ViewAssingments(){
        int counter = 1;
        foreach (Classwork classwork in classworks)
        {
            Console.WriteLine("================================ "+counter+" ==========================================================");
            classwork.ShowClassWork();
            counter++;
            Console.WriteLine("===============================================================================================");
        }


    }
    public Classwork DoClassWork(Classwork classwork){
        Console.WriteLine($"{classwork.GetQuestion}");
        Console.WriteLine("Enter your solution: ");
        string userInput  = Console.ReadLine();
        Solution solution = new Solution(userInput,GetId());
        Console.WriteLine($"Assingment for {GetId()} done.");
        classwork.SetSolution(solution);
        return classwork;
    }
    public void SetRegNo(string regNo)
    {
        this._regNo = regNo;
    }

    public string GetRegNo()
    {
        return this._regNo;
    }

    public void SetClassworks(List<Classwork> classworks)
    {
        this.classworks = classworks;
    }

    public List<Classwork> GetClassworks()
    {
        return this.classworks;
    }

    
}