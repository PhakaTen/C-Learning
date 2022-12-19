using System;
using System.Text.Json;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;             //กำหนดค่า int
            float ImpInt = myInt;     //เปลี่ยน int to float use imp

            float myFloat = 10.1f;         //กำหนด float
            
            double myDouble = 10.533;       //กำหนด double
            float ExpDouble = (float) myDouble; //  double to float use imp
            int Impint = (int)myDouble;     // double to int use imp
            
            String myString = "123";        //กำหนด string
            
            //  Part 1
            Console.WriteLine("Part 1");
            Console.WriteLine($"My data: {myInt} {myFloat} {myDouble}");
            Console.WriteLine($"After Implicit int to float: {ImpInt}");
            Console.WriteLine($"After Implicit double to float: {ExpDouble}");

            //  Part 2
            Console.WriteLine("Part 2");
            Console.WriteLine($"My string : {myString}");
            Console.Write($"After string to int use Conversion : ");
            Console.WriteLine(myString);
            
            // Part 3  เปรียบเทียบ
            
            Console.WriteLine("Part 3");
            Console.WriteLine($"myDouble :  {myDouble}");
            Console.Write($"After Conversion: ");
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.Write($"After explicit conversion: ");
            Console.WriteLine(Impint);
            
        }
    }
}