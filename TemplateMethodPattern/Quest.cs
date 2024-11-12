namespace phuong.baocao;

public abstract class Quest
{
    public void ExecuteQuest()
    {
        Start();
        PerformTask();
        Complete();
    }

    protected abstract void Start();
    protected abstract void PerformTask();
    protected abstract void Complete();
}

