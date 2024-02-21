public class ClassTest: Classwork
{
    private int _duration;
    private DateTime _submissionDate;
    public ClassTest(int _duration, string _assId, Solution _solution, Question _question, int _score, long _studentId):base(_assId, _solution, _question, _score, _studentId){
        this._duration = _duration;
    }
    public ClassTest(){
    }
    public override bool CreateClassWork(Question question){

        return false;
    }
    public override string GetStringRepresentation(){
        //solution To String
        string sol = GetSolution().FormString();
        string quest = GetQuestion().FormString();
        return $"{GetAssId()},={sol},={quest},={GetScore()},={_duration},={_submissionDate},={GetStudentId()}";
    }
    public override void ShowClassWork(){
        string sol = GetSolution().FormString();
        string quest = GetQuestion().FormString();
        Console.WriteLine($"id== {GetAssId()}\nSolution == {sol}\nQuestion == {quest}\nScore == {GetScore()}\nDuration == {_duration}\nSubmitted On == {_submissionDate}\nDone By== {GetStudentId()}");
    }
    public void SetDuration(int duration)
        {
            this._duration = duration;
        }

    public void SetSubmissionDate(DateTime submissionDate)
        {
            this._submissionDate = submissionDate;
        }
    public int GetDuration()
        {
            return this._duration;
        }

    public DateTime GetSubmissionDate()
        {
            return this._submissionDate;
        }




}