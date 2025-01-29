class Enemy
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Attack { get; private set; }

    public Enemy(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }
}