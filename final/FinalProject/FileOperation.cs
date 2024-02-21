using System.Xml.Linq;

public class FileOperation
{
    public FileOperation(){
        
    }
    //save the classworks
    //save the questions
    //save the persons
    public void SaveclassworkToFile(){
        string fileName = "classwork.txt";
        // Console.WriteLine("Enter file name to save (e.g \"sample.txt\"): ");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // outputFile.WriteLine($"{}");
            foreach (Classwork classwork in Classroom.classworks)
            {
                outputFile.WriteLine($"{classwork.GetStringRepresentation()}");
            }
        }

    }
    //{GetAssId()},={sol},={quest},={GetScore()},={_duration},={_submissionDate},={GetStudentId()}
    //{GetAssId()},={sol},={quest},={GetScore()},={_duration},={_submissionDate}{GetStudentId(){_duedate}
    public void LoadClassWorkFromFile(){
        string fileName = "classwork.txt";
        string[] lines = File.ReadAllLines(fileName);
        Classwork classwork;
        foreach (string line in lines)
        {
            string[] parts = line.Split(",=");
            string fid = parts[0];
                string fsol = parts[1];
                string fquest = parts[2];
                string fscore = parts[3];
            if(parts.Count() < 6){
                string fduration = parts[4];
                string fsubmission = parts[5];
                string sId = parts[6];
               classwork = new ClassTest(int.Parse(fduration),fid,new Solution(fsol),new Question(fquest),int.Parse(fscore),long.Parse(sId));
            }else{
                string fduration = parts[4];
                string fsubmission = parts[5];
                string sId = parts[6];
                string fdue = parts[7];
                classwork = new Assingment(int.Parse(fduration),DateTime.Parse(fdue),fid,new Solution(fsol),new Question(fquest),int.Parse(fscore),long.Parse(sId));
            }
            Classroom.classworks.Add(classwork);
        }

    }
    //$"{GetFirstName()},={GetLastName()},={GetId()},={GetAddress()},={GetPhone()},={GetEmail()},={_regNo}"
    //{GetFirstName()},={GetLastName()},={GetId()},={GetAddress()},={GetPhone()},={GetEmail()}"
    public void LoadPeople(){
        string fileName = "classwork.txt";
        string[] lines = File.ReadAllLines(fileName);
        Person person;
        foreach (string line in lines)
        {
            string[] parts = line.Split(",=");
            string fFirst = parts[0];
                string fLast = parts[1];
                string fId = parts[2];
                string fAddress = parts[3];
                string fPhone = parts[4];
                string fEmail = parts[5];
                if(parts.Count()<7){
                    person = new Teacher(fFirst,fLast,long.Parse(fId),fAddress,fPhone,fEmail);

                }else{
                    string fRegNo = parts[6];
                    person = new Student(fFirst,fLast,long.Parse(fId),fAddress,fPhone,fEmail,fRegNo);
                }
                Classroom.people.Add(person);
        }
        Console.WriteLine("People loaded from file");
        


    }
    public void LoadQuestions(){
        string fileName = "classwork.txt";
        string[] lines = File.ReadAllLines(fileName);
        Question question;
        foreach (string line in lines)
        {
            question = new Question(line);
        }
        Console.WriteLine("Questions loaded from file");

    }
    public void savePeople(){
        string fileName = "people.txt";
        // Console.WriteLine("Enter file name to save (e.g \"sample.txt\"): ");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // outputFile.WriteLine($"{}");
            foreach (Person person in Classroom.people)
            {
                outputFile.WriteLine($"{person.ChangeToString()}");
            }
        }
        Console.WriteLine("People saved Successfully");

    }
    public void saveQuestions(){
        string fileName = "question.txt";
        // Console.WriteLine("Enter file name to save (e.g \"sample.txt\"): ");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // outputFile.WriteLine($"{}");
            foreach (Question question in Classroom.questions)
            {
                outputFile.WriteLine($"{question.FormString()}");
            }
            Console.WriteLine("Questions saved Successfully");
        }

    }
}