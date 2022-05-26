using System.Linq;

string[] names = { "dong","truc","Cong Phuong","linh","an","hai","bon","Van A"};
/*lam cach nao do sap xep mang names tang dan vao in ra ngoai */
SortedSet<string> sortedS = new SortedSet<string>(names);
foreach (string s in sortedS)
{
    Console.WriteLine(s);
}

Array.Sort<string>(names);
Console.WriteLine("=======================");
foreach (string s in names)
{
    Console.WriteLine(s);
}

Console.WriteLine("=======================");
//Linq and lambda expression

foreach (var i in names.Where(n => n.Length > 4))
{
    Console.WriteLine(i);
}
//query expression
Console.WriteLine("=======================");
var items = from n in names
            where n.Length > 4
            select n;

foreach (var item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine("=======================");
foreach (var i in names.Where(CheckLength))
{
    Console.WriteLine(i + " normal");
}

bool CheckLength(string s)
{
    return s.Length > 4;
}