namespace SchoolManagementSystem.Model;

public class Branch
{
    private int _id;
    private string _name;

    public Branch(int id, string name)
    {
        this._id = id;
        this._name = name;
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}