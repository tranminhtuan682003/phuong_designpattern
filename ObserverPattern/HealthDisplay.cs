namespace phuong.baocao;

public class HealthDisplay : IObserver
{
    public void Update(int health)
    {
        Console.WriteLine("Health Display: Health is now " + health);
    }
}

public class SoundAlarm : IObserver
{
    public void Update(int health)
    {
        if (health < 30)
        {
            Console.WriteLine("Sound Alarm: Health is low! Warning!");
        }
    }
}

