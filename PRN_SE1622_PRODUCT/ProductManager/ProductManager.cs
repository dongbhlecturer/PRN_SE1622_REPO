namespace Prn.Se1622;
public class ProductManager : AbstractProduct, IProduct
{
    public ProductManager() { }
    public void Add(Product p)
    {
       if(Size >= Products.Length)
        {
            //extends Products
            Product[] temp = new Product[Size*2];
            for(int i = 0; i < Size; i++)
            {
                temp[i] = Products[i];
            }
            Products = temp;
        }
       Products[Size++] = p;
    }

    public override void Display()
    {
        foreach(Product p in Products)
        {
            Console.WriteLine(p);
        }
    }

    public Product Get(int pos)
    {
        throw new NotImplementedException();
    }

    public void Remove(Product p)
    {
        throw new NotImplementedException();
    }
}