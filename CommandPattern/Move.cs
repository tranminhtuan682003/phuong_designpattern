namespace phuong.baocao;

public class MoveLeftCommand : ICommand
{
    private Player _player;

    public MoveLeftCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.MoveLeft();
    }
}

public class MoveRightCommand : ICommand
{
    private Player _player;

    public MoveRightCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.MoveRight();
    }
}

public class JumpCommand : ICommand
{
    private Player _player;

    public JumpCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Jump();
    }
}

public class AttackCommand : ICommand
{
    private Player _player;

    public AttackCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Attack();
    }
}
