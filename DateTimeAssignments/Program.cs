using System;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    {
        //1
        DateTime days= new DateTime(2021,8,10,10,40,32);
        Console.WriteLine("Year: "+ days.Year);
        Console.WriteLine("Month: "+ days.Month);
        Console.WriteLine("Days: "+ days.Day);
        Console.WriteLine("Hours: "+ days.Hour);
        Console.WriteLine("Minutes: "+ days.Minute);
        Console.WriteLine("Seconds: "+days.Second);

        //2
        string s=days.ToString("yyyy/MM/dd hh:mm:ss tt");
        string[] arr=s.Split('/',' ',':');
        for(int i=arr.Length-1;i>=0;i--){
            Console.Write(arr[i]+" ");
        }

        //3
        Console.WriteLine("Enter the date and time in format of yyyy/MM/dd hh:mm:ss tt");
        DateTime value= DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        
        Console.WriteLine(value.ToString("yyyy"));
        Console.WriteLine(value.ToString("MM"));
        Console.WriteLine(value.ToString("dd"));


    }
}
