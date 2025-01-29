using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mahmut's Dungeon ===");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Credits");
            Console.WriteLine("3 - Exit");
            Console.Write("Your choice ? ");
            string choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                Game game = new Game();
                game.Start();
            }
            else if (choice1 == "2")
            {
                Console.Clear();
                Console.WriteLine("=== Credits ===");
                Console.WriteLine("Made By Anil Emre Ay For Game Programming Final ");
                Console.WriteLine("For some parts (turn-based combat) there was some help from the AI with some ideas on how it could be done. Like the idea of adding System.Collections.Generic; to be able to use List<T> ");
                Console.WriteLine("\nPress ENTER to return to the main menu.");
                Console.ReadLine();
            }
            else if (choice1 == "3")
            {
                break;
            }
        }
    }
}