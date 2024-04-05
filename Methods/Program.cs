using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
namespace Methods;
class Program{
    public static void Main(string[] args)

    {
        bool flag=true;
        do{
        Console.Write("Enter the number1: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the number2: ");
        int number2=int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1. Addition ");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");

        int option=int.Parse(Console.ReadLine());

        switch(option){
            case 1:{
                Console.WriteLine(Add(number1,number2));
                break;
            }
            case 2:{
                Console.WriteLine(Subtraction(number1,number2));
                break;
            }
            case 3:{
                Console.WriteLine(Multiplication(number1,number2));
                break;
            }
            case 4:{
                Console.WriteLine(Division(number1,number2));
                break;
            }

        }
         
        Console.Write("Do you continue the process.Enter yes/no: ");
        string value=Console.ReadLine();

        if(value=="yes"){
            flag=true;
        }else if(value=="no"){
            flag=false;
        }
        else{
            Console.Write("Re Enter the correct option yes/no: ");
        }
        }while(flag);

        static int Add(int number1,int number2){
            int sum=number1+number2;
            return sum;

        }
        static int Subtraction(int number1,int number2){
            int sub=number1-number2;
            return sub;

        }
        static int Multiplication(int number1,int number2){
            int mul=number1*number2;
            return  mul;

        }
        static int Division(int number1,int number2){
            int div=number1/number2;
            return div;

        }

        
    }
}
