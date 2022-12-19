using System;

namespace Gl113_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string charname = "Ling";    // Var of character name
            string gamename = "Arknights.";    // Var of game name
            char tier = 'S';                    // Var of character tier 
            int stat = 433;                    //Var of character status
            float aspd = 35.5f;                    //Var of character attack speed
            
            // Display
            Console.WriteLine($"My favorite character is {charname} From a game name {gamename}" );
            Console.WriteLine(
                $"She is a {tier} Tier character with overall status of {stat} and attackspeed of {aspd}");
            
        }
    }
}