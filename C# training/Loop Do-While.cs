using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Draw a half pyramid with text");
            Console.Write("fill your text : ");
            string text = Console.ReadLine();
            text = text + " ";
            string text2 = text;
            Console.Write("How many row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------- Start ----------");
            while (row > 0)
            {
                Console.WriteLine($"{text2.ToUpper()}");
                text2 += text;
                row--;
                continue;
            }
            Console.WriteLine("---------- End ----------");
        }
    }
}