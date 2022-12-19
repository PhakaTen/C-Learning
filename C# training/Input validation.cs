using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Welcome to superrich Thailand ---");
            Console.WriteLine("\n- AUS Dollar Buying 0.40/ Selling 24.82");
            Console.WriteLine("-Press '1' for Buying");
            Console.WriteLine("-Press '2' for Selling");
            Console.Write("-Choose Menu (1/2): ");
            string option = Console.ReadLine();
            int intoption;
            bool check = int.TryParse(option,out intoption);                                //input validation
            if (check == false)
            {
                Console.WriteLine("Plese type the number 1 or 2");
                return;
            }

            if (intoption < 1 || intoption > 2)
            {
                Console.WriteLine("Plese type the number 1 or 2");
                return;
            }
            if (intoption == 1)
            {
                Console.WriteLine("Exchanging THB to AUS Dollar");
            }
            if (intoption == 2)
            {
                Console.WriteLine("Exchanging AUS dollar to THB");
            }


            Console.Write("How much would you like: ");
            string stramount = Console.ReadLine();                                                          //recieve amount of money
            double douamount;
            bool checkamount = double.TryParse(stramount, out douamount);
            if (checkamount == false)
            {
                Console.WriteLine("Plese enter a number");
                return;
            }

            double thbtoaus = douamount * 0.40;                                                             // calculate
            double austothb = douamount * 24.82;
            if (intoption == 1)
            {
                Console.WriteLine($"Exchanged amount is : {thbtoaus} Dollar");
            }

            if (intoption == 2)
            {
                Console.WriteLine($"Exchanged amount is : {austothb} Baht");
            }
            
        }
    }
}