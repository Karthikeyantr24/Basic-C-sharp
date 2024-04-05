using System;
using Microsoft.Win32.SafeHandles;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
         Console.Write("Enter the Number1: ");
        int num1=int.Parse(Console.ReadLine());
         Console.Write("Enter the Number2: ");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an Option: ");
        Console.WriteLine("+ for Addition");
        Console.WriteLine("- for Subtraction");
        Console.WriteLine("* for Multiplication");
        Console.WriteLine("/ for Division of Quotient Value");
        Console.WriteLine("% for Division of Remainder Value");

        Console.Write("Enter the operation: ");
        char operand=char.Parse(Console.ReadLine());

        switch(operand){
            case '+':{
                Console.WriteLine(num1+num2);
                break;
            }
            case '-':
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case '*':
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case '/':
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case '%':
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Operation is Invalid");
                break;
            }
        }
      
        
    }
}

