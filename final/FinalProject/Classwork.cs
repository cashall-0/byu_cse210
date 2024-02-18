public abstract class Classwork
{
    private string _assId;
    private Solution _solution;
    private string _question;
    private int _score;

    public Classwork (){
        
    }
    public Classwork (string _assId, Solution _solution, string _question, int _score){
        this._assId = _assId;
        this._question = _question;
        this._score = _score;
        this._solution = _solution;
        
    }
    public abstract bool ScoreClassWork();
    public abstract bool CreateClassWork();
    public void SetAssId(string assId)
    {
        this._assId = assId;
    }

    public string GetAssId()
    {
        return this._assId;
    }

    public void SetSolution(Solution solution)
    {
        this._solution = solution;
    }

    public Solution GetSolution()
    {
        return this._solution;
    }

    public void SetQuestion(string question)
    {
        this._question = question;
    }

    public string GetQuestion()
    {
        return this._question;
    }

    public void SetScore(int score)
    {
        this._score = score;
    }

    public int GetScore()
    {
        return this._score;
    }

}