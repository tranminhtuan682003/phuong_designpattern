namespace phuong.baocao;

public class CharacterBuilder
{
    private string name = "Unknown";
    private int attackPower = 10;
    private int defense = 5;
    private int health = 100;
    private int magic = 0;

    public CharacterBuilder SetName(string name)
    {
        this.name = name;
        return this;
    }

    public CharacterBuilder SetAttackPower(int attackPower)
    {
        this.attackPower = attackPower;
        return this;
    }

    public CharacterBuilder SetDefense(int defense)
    {
        this.defense = defense;
        return this;
    }

    public CharacterBuilder SetHealth(int health)
    {
        this.health = health;
        return this;
    }

    public CharacterBuilder SetMagic(int magic)
    {
        this.magic = magic;
        return this;
    }

    public Character Build()
    {
        return new Character(name, attackPower, defense, health, magic);
    }
}
