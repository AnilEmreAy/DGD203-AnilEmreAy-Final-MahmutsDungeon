using System;

class Battle
{
    private Player player;
    private Enemy enemy;
    private Random random = new Random();
    private int missChance = 20; 

    public Battle(Player player, Enemy enemy)
    {
        this.player = player;
        this.enemy = enemy;
    }

    public bool Start()
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();
            Console.WriteLine($"Your Health: {player.Health}");
            Console.WriteLine($"{enemy.Name} Health: {enemy.Health}");
            Console.WriteLine($"Current Miss Chance: {missChance}%");
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Block");
            Console.Write("What will you do ? ");

            string choice2 = Console.ReadLine();

            if (choice2 == "1") 
            {
                if (random.Next(1, 101) <= missChance) 
                {
                    Console.WriteLine("You missed!");
                }
                else
                {
                    enemy.Health -= player.Attack;
                    Console.WriteLine($"{enemy.Name} took {player.Attack} damage from you");
                }

                
                missChance = Math.Min(missChance + 10, 60);
            }
            else if (choice2 == "2") 
            {
                Console.WriteLine("You Blocked! You took no damage.");

                
                missChance = 20;

                
                int healAmount = (int)(enemy.Health * 0.40);
                enemy.Health = Math.Min(enemy.Health + healAmount, enemy.MaxHealth);
                Console.WriteLine($"{enemy.Name} healed for {healAmount} HP!");

                Console.ReadLine();
                continue;
            }

            if (enemy.Health > 0)
            {
                player.Health -= enemy.Attack;
                Console.WriteLine($"{enemy.Name} gave you {enemy.Attack} damage");
            }

            Console.WriteLine("\nPress ENTER to continue.");
            Console.ReadLine();
        }

        return player.Health > 0;
    }
}