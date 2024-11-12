namespace phuong.baocao;

public class HealthSystem
{
    private List<IObserver> observers = new List<IObserver>();
    private int health;

    public HealthSystem(int initialHealth)
    {
        health = initialHealth;
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
        Notify();
    }

    private void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(health);
        }
    }
}
