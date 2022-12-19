using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a value : ");
            float a;
            bool abool = Single.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter b value : ");
            float b;
            bool bbool = Single.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter c value : ");
            float c;
            bool cbool = Single.TryParse(Console.ReadLine(), out c);
            Console.Write("Enter radius : ");
            float r;
            bool rbool = Single.TryParse(Console.ReadLine(), out r);

            if (abool == false || bbool == false || cbool == false || rbool == false)
            {
                Console.WriteLine("Something wrong plese enter value again");
                return;
            }

            Console.WriteLine($"value of a = {a}");
            Console.WriteLine($"value of b = {b}");
            Console.WriteLine($"value of c = {c}");
            Console.WriteLine($"value of radius = {r}");
            
            float s = (a + b + c) / 2;
            float triarea = Convert.ToSingle(Math.Sqrt(s*(s - a) * (s - b) * (s - c)));
            string triareastr = string.Format("{0:0.0}", triarea);
            Console.WriteLine($"Area of triangle is {triareastr}");

            double cirarea = (Math.PI * Math.Pow(r, 2));
            Console.WriteLine($"Area of Circle is {cirarea}");
            
            bool result;
            result = triarea > cirarea;

            Console.WriteLine($"the area of triangle is greater than circle : {result}");
            
            
}
}
}