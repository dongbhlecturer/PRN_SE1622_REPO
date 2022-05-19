namespace Prn.Se1622;
public class Person
{
    protected string Name { get; set; }
    protected Address Address { get; set; }//HAS-A (mot cach ke thua)
    protected DateTime Dob { get; set; }

    public Person() { }

    public Person(string name, Address address, DateTime dob)
    {
        Name = name;
        Address = address;
        Dob = dob;
    }
    public virtual string Display()
    {
        return $"[Name = {Name}], Adress={Address}, Dob = {Dob}";
    }
}