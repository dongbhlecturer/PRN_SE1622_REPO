namespace Threading;
public class Program
{
    public static void Main()
    {
        //1. Thuc thi dong bo
        /*
        PrintNumber();
        Console.WriteLine("=======================");
        PrintNumber();
        Console.WriteLine("=======================");
        PrintNumber();
        */
        //2. Tao ra 3 thread, moi mot thread thuc thi 1 nhiem vu cua rieng minh
        for(int i = 1; i <= 5; i++)
        {
            new Thread(() => PrintNumber(i)).Start();
        }

        

        Console.WriteLine("All finished...");

        Console.ReadLine();
    }


    public static void PrintNumber(int indexThread)
    {
        for(int i = 1; i <=5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {indexThread}: {i}");
        }
    }

}