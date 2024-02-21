public class Assingment : Classwork
{
    private DateTime _dueDate;
    private int _duration;
    private DateTime _submissionDate;
    
    public Assingment(int _duration, DateTime _dueDate, string _assId, Solution _solution, Question _question, int _score, long _studentId):base(_assId, _solution, _question, _score, _studentId){
        this._dueDate = _dueDate;
        this._duration =_duration;
    }
    public override bool CreateClassWork(Question question){

        return false;
    }
    public override string GetStringRepresentation(){
        //solution To String
        string sol = GetSolution().FormString();
        string quest = GetQuestion().FormString();
        return $"{GetAssId()},={sol},={quest},={GetScore()},={_dueDate},={_submissionDate},={GetStudentId()}";
    }
    public override void ShowClassWork(){
        string sol = GetSolution().FormString();
        string quest = GetQuestion().FormString();
        Console.WriteLine($"id== {GetAssId()}\nSolution == {sol}\nQuestion == {quest}\nScore == {GetScore()}\nDueDate == {_dueDate}\nSubmitted On == {_submissionDate}\n Done By== {GetStudentId()}");
    }
    public void SetDueDate(DateTime dueDate)
        {
            this._dueDate = dueDate;
        }

    public DateTime GetDueDate()
        {
            return this._dueDate;
        }

    public void SetSubmissionDate(DateTime submissionDate)
        {
            this._submissionDate = submissionDate;
        }

    public DateTime GetSubmissionDate()
        {
            return this._submissionDate;
        }

      
}