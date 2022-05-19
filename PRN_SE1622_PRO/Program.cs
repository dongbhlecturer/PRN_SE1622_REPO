namespace fptedu.se1622;//.NET 6
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, World....");

        //declare more variables
        Console.WriteLine($"Enter values for x and y: ");
        
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int name;
        
        var salary = 100.5;//System.Double (CTS) double 
        Console.WriteLine(salary.GetType().Name);

        dynamic age = 20; //int32
        age = true; //bool
       

        Console.WriteLine($"Total of a ={x} and b = {y} is: {Sum(x,y)}");
        
        Console.WriteLine(123_456_789 * 10);
        
        Console.ReadLine(); 
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}



