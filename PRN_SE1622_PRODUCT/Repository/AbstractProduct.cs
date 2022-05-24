namespace Prn.Se1622;
public abstract class AbstractProduct
{
    private Product[] products;
    

    protected Product[] Products { get => products; set => products = value; }
    protected int Size { get; set; }// cho biet so luong phan tu co that trong mang
    public AbstractProduct()
    {
        this.products = new Product[Utils.InitNumberArray];
        Size = 0;
    }

   public abstract void Display();
}