class Player
{
    public int Health { get; set; }
    public int Attack { get; set; }

    public Player()
    {
        Health = 50;
        Attack = 10;
    }

    public void LevelUp()
    {
        Health += 10;
        Attack += 2;
        Console.WriteLine("You became stronger with the loot you got from the monster! Your New Health: " + Health + " | Your New Attack Power: " + Attack);
        Console.WriteLine("\nPress ENTER to continue.");
        Console.ReadLine();
    }
}