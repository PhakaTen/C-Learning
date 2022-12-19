using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your product cost: ");
            String checkcost = Console.ReadLine();
            double cost;
            bool check = Double.TryParse(checkcost, out cost);
            if (check == false)
            {
                Console.WriteLine("Input is not valid");
                return;
            }
            double result = (cost * 130)/100;
            Console.WriteLine(result);
        }
    }
}