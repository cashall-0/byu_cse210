public class ClassTest: Classwork
{
    private int _duration;
    private DateOnly _submissionDate;
    public ClassTest(int _duration, string _assId, Solution _solution, string _question, int _score):base(_assId, _solution, _question, _score){
        this._duration = _duration;
    }
    public override bool ScoreClassWork(){
        return false;
    }
    public override bool CreateClassWork(){
        return false;
    }
    public void SetDuration(int duration)
        {
            this._duration = duration;
        }

    public void SetSubmissionDate(DateOnly submissionDate)
        {
            this._submissionDate = submissionDate;
        }
    public int GetDuration()
        {
            return this._duration;
        }

    public DateOnly GetSubmissionDate()
        {
            return this._submissionDate;
        }




}