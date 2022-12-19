using System;
using System.Data;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGame rules :\n1. Player will have 5 turn to make a move before engaging in a combatin turn 5\n2. In each turn there are 3 options");
            Console.WriteLine("3. Each option benefit differently\n4. The option are\n  4.1 Train a Troop. Troop will fight for the faction\n");
            Console.WriteLine($"  4.2 Build a Military Factory. Military Factory will increase rate of Troop Training by 1 each\n");
            Console.WriteLine($"  4.3 Build a Trench. Trench will decrease loss of Troop in combat by 1\n");
            Console.WriteLine("5. In every 5 turn player will engage an AI Troop\n6. To win a battle Player need to have less Troop lost in Combat than AI");
            Console.WriteLine("7. To win a game player need to have more HP than AI\n");
            int Ahp = 100;
            int Bhp = 100;
            int Atroop = 1;
            int Btroop = 1;
            int AFac = 1;
            int BFac = 1;
            int Atrench = 0;
            int Btrench = 0;
            int round = 1;
            int Bdis;
            int result;
            string action;
            Random rnd = new Random();
            while (round != 21)
            {
                while (round % 5 != 0) 
                {
                    Bdis = rnd.Next(1, 3);
                    if (Bdis == 1)
                    {
                        Btroop += BFac;
                        Btroop++;
                    }
                    if (Bdis == 2)
                    {
                        BFac++;
                    }
                    if (Bdis == 3)
                    {
                        Btrench++;
                    }
                    Console.WriteLine($"-------------------------------------------------\n\nTurn : {round}\n");
                    Console.WriteLine("Train Troop {A}\nBuild Military Factory {B}\nBuild Trench {C}");
                    Safe:
                    Console.Write("Enter your action :");
                    action = Console.ReadLine();
                    if (action == "A" || action == "a")
                    {
                        Atroop += AFac;
                        Atroop++;
                    } else if (action == "B" || action == "b")
                    {
                        AFac++;
                    } else if (action == "C" || action == "c")
                    {
                        Atrench++;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease input A B C only");
                        goto Safe;
                    }
                    Console.WriteLine(
                        $"\nPlayer stat\nHP : {Ahp}\nTroop : {Atroop}\nMillitary Factory : {AFac}\nTrench : {Atrench}\n");
                    
                    round++;
                    goto Found;
                }
                Found:
                if (round % 5 == 0)
                {
                    Console.WriteLine($"!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\nTurn : {round}\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                    Console.WriteLine(
                        $"\nAI faction stat\nHP : {Bhp}\nTroop : {Btroop}\nMillitary Factory : {BFac}\nTrench : {Btrench}");
                    Console.WriteLine("Engaging a combat with an AI\n");
                    
                    if (Atroop > Btroop && (Atroop - Btroop) >0)
                    {
                        result = Math.Abs(Atroop - Btroop);
                        result -= Btrench;
                        if (result <= 0)
                        {
                            goto Clear;
                        }
                        Bhp -= result;
                        Atroop = 0;
                        Btroop = 0;
                        Console.WriteLine($"Player inflict {result} damage to AI");
                    }else if (Atroop < Btroop && (Btroop - Atroop) >0)
                    {
                        result = Math.Abs(Btroop - Atroop);
                        result -= Atrench;
                        if (result <= 0)
                        {
                            goto Clear;
                        }
                        Ahp -= result;
                        Atroop = 0;
                        Btroop = 0;
                        Console.WriteLine($"AI inflict {result} damage to Player");
                    }
                    Clear:
                    if (Atroop - Btroop <= 0 || Btroop - Atroop <= 0)
                    {
                        Console.WriteLine("Damage output = 0\nNo damage were inflicted this round");
                    }
                    Console.WriteLine($"Player HP : {Ahp}");
                    Console.WriteLine($"AI HP : {Bhp}\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    round++;
                }
            }
            string StrAhp = Convert.ToString(Ahp);
            string StrBhp = Convert.ToString(Bhp);
            string[] HPremain = {StrAhp,StrBhp };
            Array.Sort(HPremain);
            if (Ahp > Bhp)
            {
                Console.WriteLine($"You Win!!!! Player Score = {Ahp}");
            }
            if (Bhp > Ahp)
            {
                Console.WriteLine("You lose!!!! AI Score = "+Bhp);
            }
        }
    }
}