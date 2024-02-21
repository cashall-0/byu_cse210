public class Solution
{
    private string _answers;
    private long _author;
    public Solution(){
        
    }
    public Solution(string answers, long author){
        this._answers = answers;
        this._author = author;
        
    }
    public Solution(string loadFromFile){
        string[] splitSol = loadFromFile.Split(",=");
        this._answers = splitSol[0];
        this._author = long.Parse(splitSol[1]);
    }
    public string FormString(){
        return $"{_answers},={_author}";
    }
    public void SetAnswers(string answers)
    {
        this._answers = answers;
    }

    public string GetAnswers()
    {
        return this._answers;
    }

    public void SetAuthor(long author)
    {
        this._author = author;
    }

    public long GetAuthor()
    {
        return this._author;
    }

}