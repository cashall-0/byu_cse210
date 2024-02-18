public class Author : Person
{
    private string _regNo;
    private List<Classwork> classworks;
    
    public Author(string _firstName, string _lastName, long _id, string _address, string _phone, string _email):base(_firstName, _lastName, _id, _address, _phone, _email){

    }
    public override string ChangeToString()
    {
        return "";
    }
    public void SetRegNo(string regNo)
    {
        this._regNo = regNo;
    }

    public string GetRegNo()
    {
        return this._regNo;
    }

    public void SetClassworks(List<Classwork> classworks)
    {
        this.classworks = classworks;
    }

    public List<Classwork> GetClassworks()
    {
        return this.classworks;
    }

    
}