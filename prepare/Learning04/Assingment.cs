public class Assingment
{
    protected string _studentName;
    protected string _topic;
    public Assingment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary(){
        return _studentName + " - "+ _topic;
    }

}