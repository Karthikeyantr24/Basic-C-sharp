using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        // Question 1
        int i=0;
        while(i<=25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }

        //Question 2
       Console.Write("Enter a number: ");
       bool isValid=int.TryParse(Console.ReadLine(),out int output);
       while(!isValid){
        Console.Write("Invalid Number. Enter Again: ");
        isValid=int.TryParse(Console.ReadLine(),out output);

       }
       Console.WriteLine(output);
    }
}
