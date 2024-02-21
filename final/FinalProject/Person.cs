public abstract class Person
{
    private string _firstName;
    private string _lastName;
    private long _id;
    private string _address;
    private string _phone;
    private string _email;
    private bool _isStaff;

    public Person(){

    }
       public Person(string _firstName, string _lastName, long _id, string _address, string _phone, string _email, bool _isStaff) {
        this._firstName = _firstName;
        this._lastName = _lastName;
        this._id = _id;
        this._address = _address;
        this._phone = _phone;
        this._email = _email;
        this._isStaff = _isStaff;
    }
    public abstract string ChangeToString();
    public bool GetIsStaff(){
        return _isStaff;
    }

    public string GetFirstName() {
        return _firstName;
    }

    public void SetFirstName(string _firstName) {
        this._firstName = _firstName;
    }

    public string GetLastName() {
        return _lastName;
    }

    public void SetLastName(string _lastName) {
        this._lastName = _lastName;
    }

    public long GetId() {
        return _id;
    }

    public void SetId(long _id) {
        this._id = _id;
    }

    public string GetAddress() {
        return _address;
    }

    public void SetAddress(string _address) {
        this._address = _address;
    }

    public string GetPhone() {
        return _phone;
    }

    public void SetPhone(string _phone) {
        this._phone = _phone;
    }

    public string GetEmail() {
        return _email;
    }

    public void SetEmail(string _email) {
        this._email = _email;
    }
}