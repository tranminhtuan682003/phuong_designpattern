namespace phuong.baocao;

public class CollectQuest : Quest
{
    protected override void Start()
    {
        Console.WriteLine("CollectQuest: Starting collection quest...");
    }

    protected override void PerformTask()
    {
        Console.WriteLine("CollectQuest: Collecting items...");
    }

    protected override void Complete()
    {
        Console.WriteLine("CollectQuest: Quest completed! Items collected.");
    }
}

public class BattleQuest : Quest
{
    protected override void Start()
    {
        Console.WriteLine("BattleQuest: Starting battle quest...");
    }

    protected override void PerformTask()
    {
        Console.WriteLine("BattleQuest: Engaging in combat...");
    }

    protected override void Complete()
    {
        Console.WriteLine("BattleQuest: Quest completed! Enemies defeated.");
    }
}
