public class Teacher:Person
{
    public Teacher(string _firstName, string _lastName, long _id, string _address, string _phone, string _email):base(_firstName, _lastName, _id, _address, _phone, _email){
        
    }
    public override string ChangeToString()
    {
        return "";
    }

    public bool ScoreClassWork(){
        return false;
    }
    public bool CreateClassWork(){
        return false;
    }
}