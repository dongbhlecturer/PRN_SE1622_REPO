using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;
public class Program
{
    public static void Main()
    {
        string msgData = "ABCDEdfG";
        //1. stream va luu vao file data.dat (path)

       using FileStream fileStream = File.Open("data.dat",FileMode.Create);

        byte[] buffer = Encoding.UTF8.GetBytes(msgData);

       //2. ghi vao file ma dang mo san
       fileStream.Write(buffer, 0, buffer.Length);  
       fileStream.Position = 0;


        //Read

        byte[] a = {65,12,33,45,77,8,9};

        Console.WriteLine(Encoding.UTF8.GetString(buffer));

    }
}