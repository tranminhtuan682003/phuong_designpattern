namespace phuong.baocao;

public class SwordAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Attacking with a sword!");
    }
}

public class MagicAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Attacking with magic!");
    }
}

public class BowAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Attacking with a bow!");
    }
}
