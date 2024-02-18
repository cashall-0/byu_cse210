public abstract class Person
{
    private string _firstName;
    private string _lastName;
    private long _id;
    private string _address;
    private string _phone;
    private string _email;

    public Person(){

    }
       public Person(string _firstName, string _lastName, long _id, string _address, string _phone, string _email) {
        this._firstName = _firstName;
        this._lastName = _lastName;
        this._id = _id;
        this._address = _address;
        this._phone = _phone;
        this._email = _email;
    }
    public abstract string ChangeToString();

    public string get_firstName() {
        return _firstName;
    }

    public void set_firstName(string _firstName) {
        this._firstName = _firstName;
    }

    public string get_lastName() {
        return _lastName;
    }

    public void set_lastName(string _lastName) {
        this._lastName = _lastName;
    }

    public long get_id() {
        return _id;
    }

    public void set_id(long _id) {
        this._id = _id;
    }

    public string get_address() {
        return _address;
    }

    public void set_address(string _address) {
        this._address = _address;
    }

    public string get_phone() {
        return _phone;
    }

    public void set_phone(string _phone) {
        this._phone = _phone;
    }

    public string get_email() {
        return _email;
    }

    public void set_email(string _email) {
        this._email = _email;
    }
}