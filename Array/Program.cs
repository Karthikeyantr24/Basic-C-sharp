using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] array1=new string[5];
        //Get names from user
        for(int i=0;i<array1.Length;i++){
            array1[i]=Console.ReadLine();
        }
        //print all the names
        for(int i=0;i<array1.Length;i++){
            Console.WriteLine(array1[i]);
        
        }
        // Get a name for search in array
        Console.Write("Enter a name for search in array: ");
        string name=Console.ReadLine();
        int count=0;
        for(int i=0;i<array1.Length;i++){
            if(array1[i]==name){
                Console.WriteLine("The name is present in an array");
                Console.WriteLine("It's Index is : "+i);
                break;
            }
            count++;
            
        }
        if(count==array1.Length){
            Console.WriteLine("The name is not present in array");

        }

        count=0;
        foreach(string i in array1){
            if(i==name){
                Console.WriteLine("The name is present in array");
                break;
            }
            count++;
        }
        if(count==array1.Length){
            Console.WriteLine("The name is not in array");
        }
       


    }
}
