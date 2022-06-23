using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace DemoDatabaseFirst.Entities;

public class Program
{
    public static void Main()
    {
        
        using (FptEduStoreContext db = new())
        {
            IQueryable<Category> categories = db.Categories;//.Include(c=>c.Products);//lazy loading


            foreach (var i in categories)
            {

                

                Console.WriteLine($"Category ID: {i.CategoryId}, {i.CategoryName}, " +
                    $"Number of Products: {i.Products.Where(p=>p.UnitPrice>=18).Count()}");

                

                //lay ra cac products ma co unitprice >=18
                /*
                var products = from p in i.Products
                               where p.UnitPrice >=18
                               select p;

                */
                var products = i.Products
                    .Where(p => p.UnitPrice >= 18)
                    .ToList();
                

                foreach (var p in products)
                {
                    Console.WriteLine($"\t - Product Id: {p.ProductId}, Product Name: {p.ProductName}");
                }
            }
        }


        Console.ReadLine(); 

    }
}