namespace phuong.baocao;

public class Character
{
    public string Name { get; private set; }
    public int AttackPower { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Magic { get; private set; }

    public Character(string name, int attackPower, int defense, int health, int magic)
    {
        Name = name;
        AttackPower = attackPower;
        Defense = defense;
        Health = health;
        Magic = magic;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Name: {Name}, Attack Power: {AttackPower}, Defense: {Defense}, Health: {Health}, Magic: {Magic}");
    }
}
