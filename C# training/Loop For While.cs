using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int x;
            Console.Write("Enter an integer number : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Continue? Y/N : ");
            string check = Console.ReadLine();
            while (check == "y" || check == "Y")
            {
                Console.Write("Enter an integer number : ");
                x = Convert.ToInt32(Console.ReadLine());
                i += x;
                Console.Write("Continue? Y/N : ");
                string check1 = Console.ReadLine();
                if (check1 == "n" || check1 == "N")
                {
                    break;
                }
            }
            Console.WriteLine($"Sum of all number = {i}");
        }
    }
}