namespace Prn.Se1622;
public class Employee:Person
{
    public int Id { get; set; }
    public double Salary { get; set; }
    public string Level { get; set; }

    public Employee() { }

    public Employee(int id, string name, Address address, DateTime dob, double salary, string level):base(name,address,dob)
    {
        Id = id;
        Salary = salary;
        Level = level;
    }
    public override string Display()
    {
        return $"Id = {Id}, Salary = {Salary}, Level={Level}" + base.Display();
    }

    public override string? ToString()=> $"Id = {Id}, Salary = {Salary}, Level={Level}" + base.Display();

}