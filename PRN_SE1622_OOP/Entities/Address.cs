namespace Prn.Se1622;

public class Address
{
    public int No { get; set; }
    public string Ward { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public Address() { }
    public Address(int no, string ward, string street, string city)
    {
        No = no;
        Ward = ward;
        Street = street;
        City = city;
    }

    public override string? ToString()
    {
        return $"[No = {No}, Ward = {Ward}, Street = {Street}, City ={City}]";
    }
}