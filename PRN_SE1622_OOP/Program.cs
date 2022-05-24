namespace Prn.Se1622;
using static System.Console;
public class Program
{
    public static void Main()
    {
       /*
        Student s = new Student { Id=1};
       
        s.Name = "Nguyen Van A";
        s.Address = "Ha Noi";
        s.Mark = 8.5d;
        s.Dob = new DateOnly();
       */
        /*
        Student a = new Student() { Id=10};
        a.Name = "Dong";
        a.Mark = 8.5d;
        a.Address = "HN";
        WriteLine(a);
        
        WriteLine("Hello");
        */

        Employee e = new Employee(1,"Dong", new Address(493,"Phuong 13","CMT8","HCM"),new DateTime(),150.66d,"Fresher");

        Person p = new Employee();//Da hinh
        WriteLine(p.Display());

       


        //WriteLine(e);

        ReadLine();
    }
}
