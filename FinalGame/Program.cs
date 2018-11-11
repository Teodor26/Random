using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace FinalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello. Let's play a game. Opt the weigth of basket: ");
            if (Int32.TryParse(Console.ReadLine(), out int weigth) && weigth >= 40 && weigth <= 140)
            {

                Console.Write("Opt the amount of players: ");
                if (Int32.TryParse(Console.ReadLine(), out int amount) && amount >= 2 && amount <= 8)
                {
                    ProgramGame<int> program = new ProgramGame<int>(weigth, amount);
                    program.Options();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Try again");
                    Main(args);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Try again.");
                Main(args);
            }

            Console.ReadLine();
        }
    }
}
