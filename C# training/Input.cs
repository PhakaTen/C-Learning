using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Username
            Console.Write("Plese enter Username : ");      //Ask user to input name
            String Username = Console.ReadLine();           //Set User input Variable as String
            
            //Input Money
            Console.Write($"Enter the amount : ");          //Ask user to input money amount
            String MoneyamountStr = Console.ReadLine();     //Set User input as Srting
            Double MoneyamountDouble;                       //Declare New Variable to convert String -> Double
            bool result = Double.TryParse(MoneyamountStr, out MoneyamountDouble);       //Use Tryphase to convert String -> Double
            
            Console.WriteLine($"\nUsername : {Username}" );                                                                   //Write Username
            Console.WriteLine($"You paid {MoneyamountDouble.ToString("0.00")} baht. TryPhase result is {result}");      //Write Result



        }
    }
}