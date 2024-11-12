namespace phuong.baocao;

public class Archer : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Archer attacks with a bow!");
    }

    public void UseArrowRain()
    {
        Console.WriteLine("Archer unleashes a rain of arrows!");
    }
}
