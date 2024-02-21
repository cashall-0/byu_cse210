public class Question
{
    private int _questionId;
    private string _question;
    private long _author;
    private int _duration;
    private int _maxScore;
    private DateTime _dueDate;
    public Question(int questionId, string question, long author, int duration, int maxScore, DateTime dueDate)
{
    _questionId = questionId;
    _question = question;
    _author = author;
    _duration = duration;
    _maxScore = maxScore;
    _dueDate = dueDate;
}
public Question(string strFromFile)
{
    string[] fs= strFromFile.Split(",=");
    _questionId = int.Parse(fs[0]);
    _question = fs[1];
    _author = long.Parse(fs[2]);
    _duration =int.Parse(fs[3]);
    _maxScore = int.Parse(fs[4]);
    _dueDate = DateTime.Parse(fs[5]);
}
public Question(){

}
public string FormString(){
        return $"{_questionId},={_question},={_author},={_duration},={_maxScore},={_dueDate}";
    }



    public void SetQuestionId(int questionId)
{
    this._questionId = questionId;
}

public int GetQuestionId()
{
    return this._questionId;
}

public void SetQuestion(string question)
{
    this._question = question;
}

public string GetQuestion()
{
    return this._question;
}

public void SetAuthor(long author)
{
    this._author = author;
}

public long GetAuthor()
{
    return this._author;
}

public void SetDuration(int duration)
{
    this._duration = duration;
}

public int GetDuration()
{
    return this._duration;
}

public void SetMaxScore(int maxScore)
{
    this._maxScore = maxScore;
}

public int GetMaxScore()
{
    return this._maxScore;
}

}