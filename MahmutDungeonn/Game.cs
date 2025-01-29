class Game
{
    private Player player;
    private Map map;

    public Game()
    {
        player = new Player();
        map = new Map(player);
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("You came as a hunter to kill this monster named Mahmut who tortures innocent people he captures just for pleasure.");
        Console.WriteLine("You examined the dungeon from a distance and made a sketch in your head, a map for yourself.");
        Console.WriteLine("\nPress ENTER to continue.");
        Console.ReadLine();
        map.Explore();
    }
}