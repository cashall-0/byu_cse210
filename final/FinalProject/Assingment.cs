public class Assingment : Classwork
{
    private DateOnly _dueDate;
    private DateOnly _submissionDate;
    public Assingment(DateOnly _dueDate, string _assId, Solution _solution, string _question, int _score):base(_assId, _solution, _question, _score){
        this._dueDate = _dueDate;

    }
    public override bool ScoreClassWork(){
        return false;
    }
    public override bool CreateClassWork(){
        return false;
    }
    public void SetDueDate(DateOnly dueDate)
        {
            this._dueDate = dueDate;
        }

    public DateOnly GetDueDate()
        {
            return this._dueDate;
        }

    public void SetSubmissionDate(DateOnly submissionDate)
        {
            this._submissionDate = submissionDate;
        }

    public DateOnly GetSubmissionDate()
        {
            return this._submissionDate;
        }

      
}