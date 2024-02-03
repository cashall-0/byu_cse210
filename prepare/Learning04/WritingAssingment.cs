public class WritingAssingment : Assingment
{
    private string _title;

    public WritingAssingment(string title, string studentName, string topic):base(studentName, title){
        this._title = title;
    }
    public string getWritingInformation(){
        return _title;
    }
    

}