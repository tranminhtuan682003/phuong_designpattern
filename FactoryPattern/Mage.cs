namespace phuong.baocao;

public class Mage : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Mage attacks with magic!");
    }

    public void CastSpell()
    {
        Console.WriteLine("Mage casts a powerful spell!");
    }
}