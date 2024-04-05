using System;
using System.Numerics;
namespace Assignments;
class Program{
    public static void Main(string[] args)
    {
       
        Console.Write("Enter your Name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age =int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        int subject1=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        int subject2=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        int subject3=int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long num=long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail=Console.ReadLine();


       //output
        Console.WriteLine("Trainee Details Are: ");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Mobile: "+num);
        Console.WriteLine("Marks1: "+subject1);
        Console.WriteLine("Marks2: "+subject2);
        Console.WriteLine("Marks3: "+subject3);
        int total = subject1+subject2+subject3;
        Console.WriteLine("Total: "+total);

        double average=Convert.ToDouble(total)/3;

        Console.WriteLine("Average: "+average);
        Console.WriteLine("Grade: "+grade);
        Console.WriteLine("Mail id: "+mail);



    }
}
