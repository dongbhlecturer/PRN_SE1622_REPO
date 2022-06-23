namespace Prn.Assembly;

public static class MathLib
{
    public static int Add(this int a, int b) => a + b;
    public static int Add(this int a, int b, int c) => Add((a + b), c);
    public static int Sub(this int a, int b) => a - b;
}
