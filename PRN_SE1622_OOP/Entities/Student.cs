namespace Prn.Se1622;
public class Student
{
    /*Fields/Data*/

    private int _id;
    private string _name;
    private DateTime _dateOnly;
    private string _address;
    /*Properties*/
    //Init-auto properties
    public int Id { get; init; }
    public string Name { get => _name; set => _name = value; }
    //Readonly-properties
    public DateTime Dob { get; }
    public string Address
    {
        get { return _address;}
        set { _address = value; }
    }
    public double? Mark { get; set; }

    /*Constructors => ham khoi tao*/
    public Student()
    {

    }

    public Student(int id, string name, DateTime dob, string address, double mark)
    {
        this.Id = id;
        this.Name = name;
        Dob = dob;
        Address = address;
        Mark = mark;
    }

    /*to increase Mark with percent rate*/
    public void IncreaseMarkByPercent(int? percent)
    {
        if(percent is not null && percent > 0)
        {
            this.Mark = this.Mark * percent / 100;
        }
    }
    //Expression Bodied
    public override string? ToString() => $"[Id ={Id}, Name = {Name}, Dob ={Dob}, Address = {Address}, Mark = {Mark}]";
}