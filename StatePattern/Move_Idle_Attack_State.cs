namespace phuong.baocao;

public class IdleState : IState
{
    public void Handle(CharacterS character)
    {
        Console.WriteLine("Character is standing idle.");
    }
}

public class MovingState : IState
{
    public void Handle(CharacterS character)
    {
        Console.WriteLine("Character is moving.");
    }
}

public class AttackingState : IState
{
    public void Handle(CharacterS character)
    {
        Console.WriteLine("Character is attacking.");
    }
}
