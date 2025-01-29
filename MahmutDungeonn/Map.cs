class Map
{
    private Player player;
    private bool firstAreaCleared = false;
    private bool secondAreaCleared = false;

    public Map(Player player)
    {
        this.player = player;
    }

    public void Explore()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Map ===");
            Console.WriteLine("1 - Mahmut's dungeon entrance " + (firstAreaCleared ? "(Cleaned)" : ""));
            Console.WriteLine("2 - Inside Mahmut's dungeon " + (secondAreaCleared ? "(Cleaned)" : ""));
            Console.WriteLine("3 - Mahmut's Throne Room " + (firstAreaCleared && secondAreaCleared ? "" : "(Entrance Closed!)"));
            Console.WriteLine("4 - Back to Main Menu");
            Console.Write("What will you do ? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                firstAreaCleared = EnterLocation("Mahmut's dungeon entrance", new List<Enemy>
                {
                    new Enemy("Mahmut's Soldier", 25, 5),
                    new Enemy("Mahmut's Berber", 35, 6)
                });
            }
            else if (choice == "2")
            {
                if (!firstAreaCleared)
                {
                    Console.WriteLine("First you must clear Mahmut's Dungeon Entrance!");
                    Console.ReadLine();
                }
                else
                {
                    secondAreaCleared = EnterLocation("Inside Mahmut's dungeon", new List<Enemy>
                    {
                        new Enemy("Mahmut's Friend From Kahvehane", 40, 7),
                        new Enemy("Mahmut's Friend From Sanayi", 55, 9)
                    });
                }
            }
            else if (choice == "3")
            {
                if (firstAreaCleared && secondAreaCleared)
                {
                    EnterLocation("Mahmut's Throne Room", new List<Enemy> { new Enemy("Mahmut", 70, 11) }, isFinalBoss: true);
                }
                else
                {
                    Console.WriteLine("First you have to clear the enemies in other areas!");
                    Console.ReadLine();
                }
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }

    private bool EnterLocation(string locationName, List<Enemy> enemies, bool isFinalBoss = false)
    {
        Console.Clear();
        Console.WriteLine($"== {locationName} ==");
        Console.WriteLine("\nPress ENTER to continue.");
        Console.ReadLine();

        foreach (Enemy enemy in enemies)
        {
            Console.WriteLine($"{enemy.Name} ready for fight with you");
            Console.WriteLine("\nPress ENTER to start the battle.");
            Console.ReadLine();

            Battle battle = new Battle(player, enemy);
            bool won = battle.Start();

            if (!won)
            {
                Console.WriteLine("You died, you couldn't defeat Mahmoud and he continued to hurt innocent people all his life because of your failure... Returning to the main menu.");
                Console.ReadLine();
                return false;
            }

            player.LevelUp();
        }

        if (isFinalBoss)
        {
            Console.WriteLine("You killed Mahmut no more innocent people will be hurt and your brave victory will resound around the world...");
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            return true;
        }

        Console.WriteLine($"{locationName} successfully destroyed");
        Console.WriteLine("\nPress ENTER to continue.");
        Console.ReadLine();
        return true;
    }
}