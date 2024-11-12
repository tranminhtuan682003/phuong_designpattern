namespace phuong.baocao;

public class CharacterStrategy
{
    private IAttackStrategy attackStrategy;

    public CharacterStrategy(IAttackStrategy attackStrategy)
    {
        this.attackStrategy = attackStrategy;
    }

    public void SetAttackStrategy(IAttackStrategy newStrategy)
    {
        attackStrategy = newStrategy;
    }

    public void PerformAttack()
    {
        attackStrategy.Attack();
    }
}
