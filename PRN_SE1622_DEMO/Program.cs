Main();
static void Main()
{
    int x = 1, y = 2;
    void ShowValue( int a)
    {
        Console.WriteLine($"x = {x}, a={a}");
        a = 10;
    }
    ShowValue(x);
    Console.WriteLine(x);
}