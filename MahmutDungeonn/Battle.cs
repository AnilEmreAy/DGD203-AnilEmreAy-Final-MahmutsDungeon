class Battle
{
    private Player player;
    private Enemy enemy;
    private Random random = new Random();

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
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Block");
            Console.Write("What will you do ? ");

            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                if (random.Next(1, 101) <= 40)
                {
                    Console.WriteLine("You missed!");
                }
                else
                {
                    enemy.Health -= player.Attack;
                    Console.WriteLine($"{enemy.Name} took {player.Attack} damage from you");
                }
            }
            else if (choice2 == "2")
            {
                Console.WriteLine("You Blocked You took no damage.");
                Console.ReadLine();
                continue;
            }

            if (enemy.Health > 0)
            {
                player.Health -= enemy.Attack;
                Console.WriteLine($"{enemy.Name} gave you {enemy.Attack}  damage");
            }

            Console.WriteLine("\nPress ENTER to continue.");
            Console.ReadLine();
        }

        return player.Health > 0;
    }
}

