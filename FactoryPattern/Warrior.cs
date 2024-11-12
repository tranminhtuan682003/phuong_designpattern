namespace phuong.baocao;

public class Warrior : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword!");
    }

    public void Defend()
    {
        Console.WriteLine("Warrior defends with a shield!");
    }
}

