using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
       
        int number;
        string value=string.Empty;
        do{
            Console.Write("Enter a number: ");
            number=int.Parse(Console.ReadLine());

            if(number%2==0){
                Console.WriteLine("Even");
            }
            else{
                Console.WriteLine("Odd");
            }
            do{
                Console.Write("To repeat the process with another number with 'Yes' or 'No': ");
                value=Console.ReadLine();
                if(value=="yes"){
                    break;
                
                }
                else if(value=="no"){
                    break;
                }
                else{
                    Console.Write("Invalid option.Enter a Valid option: ");
                    value=Console.ReadLine();
                }
            }
                while(value=="no");
        }
            
            while(value=="yes");
        
    }
}