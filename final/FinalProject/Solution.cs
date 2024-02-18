public class Solution
{
    private string _answers;
    private Person _author;
    public Solution(){
        
    }
    public string FormString(){
        return "";
    }
    public void SetAnswers(string answers)
    {
        this._answers = answers;
    }

    public string GetAnswers()
    {
        return this._answers;
    }

    public void SetAuthor(Person author)
    {
        this._author = author;
    }

    public Person GetAuthor()
    {
        return this._author;
    }

}