public class MathAssingment : Assingment
{
    private string _textbookSection;
    private string _problems;

    public MathAssingment(String textbookSection, string problems, string studentName, string topic) : base(studentName, topic){
        this._textbookSection = textbookSection;
        this._problems = problems;
    }
    public string GetHomeworkList(){
        return _textbookSection +" "+ _problems;
    }
}