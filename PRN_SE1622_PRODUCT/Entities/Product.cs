namespace Prn.Se1622;
public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public double? UnitPrice { get; set; }

    public Product() { }

    public Product(int id, string? productName, double? unitPrice)
    {
        Id = id;
        ProductName = productName;
        UnitPrice = unitPrice;
    }

    public override string? ToString() => $"[Id = {Id}, Product Name = {ProductName} and Unit Price ={UnitPrice}]";
}