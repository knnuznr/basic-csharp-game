using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_csharp_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string[] secenekler = { "rock", "paper", "scissors" };
                Console.Write("Enter a choice:");
                string p1 = Console.ReadLine().ToLower();
                string p2;
                Random rnd = new Random();
                int vl = rnd.Next(0, secenekler.Length);

                //Game
                Console.WriteLine("Player: {0}", p1);
                Console.WriteLine("CPU: {0}", p2 = secenekler[vl]);

                if (p1 == p2)
                {
                    Console.WriteLine("It's tie!");
                }
                else if (p1 == "rock" && p2 == "scissors")
                {
                    Console.WriteLine("Player wins!");
                }
                else if (p1 == "paper" && p2 == "rock")
                {
                    Console.WriteLine("Player wins!");
                }
                else if (p1 == "scissors" && p2 == "paper")
                {
                    Console.WriteLine("Player wins!");
                }
                else
                {
                    Console.WriteLine("Player lose!");
                }
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
