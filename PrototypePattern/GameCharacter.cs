namespace phuong.baocao;

public class GameCharacter : ICloneable
{
    public string Name { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }

    public GameCharacter(string name, int attackPower, int defense, int health)
    {
        Name = name;
        AttackPower = attackPower;
        Defense = defense;
        Health = health;
    }

    public ICloneable Clone()
    {
        return new GameCharacter(Name, AttackPower, Defense, Health);
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}, Attack Power: {AttackPower}, Defense: {Defense}, Health: {Health}");
    }
}
