using System;
using System.Threading;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Main String: ");
        string mainString=Console.ReadLine();
        Console.Write("Enter the string to be searched: ");
        string word=Console.ReadLine();
        string value="";
        int count=0;
        for(int i=0;i<mainString.Length-word.Length+1;i++){
            for(int j=i;j<i+word.Length;j++){
                value+=mainString[j];
            }
            if(value==word){
                count=count+ 1;
                value="";
            }
            else{
                value="";
            }
        }Console.WriteLine(count);
      
       
    }
}
