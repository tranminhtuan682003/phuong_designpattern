namespace phuong.baocao;

public class CharacterFactory
{
    public static ICharacter CreateCharacter(string characterType)
    {
        return characterType.ToLower() switch
        {
            "warrior" => new Warrior(),
            "mage" => new Mage(),
            "archer" => new Archer(),
            _ => throw new ArgumentException("Invalid character type")
        };
    }
}

