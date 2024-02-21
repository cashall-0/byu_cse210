public abstract class Classwork
{
    private string _assId;
    private Solution _solution;
    private Question _question;
    private int _score;
    private long _studentId;

    public Classwork (){
        
    }
    public Classwork (string _assId, Solution _solution, Question _question, int _score, long _studentId){
        this._assId = _assId;
        this._question = _question;
        this._score = _score;
        this._solution = _solution;
        this._studentId = _studentId;
        
    }
    public abstract bool CreateClassWork(Question question);
    public abstract string GetStringRepresentation();
    public abstract void ShowClassWork();
    public void SetAssId(string assId)
    {
        this._assId = assId;
    }

    public string GetAssId()
    {
        return this._assId;
    }
    public void SetStudentId(long studentId)
    {
        this._studentId = studentId;
    }

    public long GetStudentId()
    {
        return this._studentId;
    }

    public void SetSolution(Solution solution)
    {
        this._solution = solution;
    }

    public Solution GetSolution()
    {
        return this._solution;
    }

    public void SetQuestion(Question question)
    {
        this._question = question;
    }

    public Question GetQuestion()
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