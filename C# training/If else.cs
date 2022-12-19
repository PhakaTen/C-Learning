using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter water capacity: ");
            string checkcap = Console.ReadLine();
            int cap;
            bool check = Int32.TryParse(checkcap, out cap);
            if (check == false)
            {
                Console.WriteLine("Input invalid");
                return;
            }

            if (cap <= 10)
            {
                Console.WriteLine("-- Flooding alarm system --");
                Console.WriteLine($"Capacity = {cap}");
                Console.WriteLine("BROWN! | water level is too low |");
            }
            else if (cap > 10 && cap <= 30)
            {
                Console.WriteLine("-- Flooding alarm system --");
                Console.WriteLine($"Capacity = {cap}");
                Console.WriteLine("YELLOW! | water level is too low |");
            }
            else if (cap > 30 && cap <=70)
            {
                Console.WriteLine("-- Flooding alarm system --");
                Console.WriteLine($"Capacity = {cap}");
                Console.WriteLine("GREEN! | water level is normal |");
            }
            else if (cap > 70 && cap < 100)
            {
                Console.WriteLine("-- Flooding alarm system --");
                Console.WriteLine($"Capacity = {cap}");
                Console.WriteLine("BLUE! | water level is too high |");
            }
            else if(cap > 100)
            {
                Console.WriteLine("-- Flooding alarm system --");
                Console.WriteLine($"Capacity = {cap}");
                Console.WriteLine("RED! | FLOODING!!! |");
            }
        }
    }
}