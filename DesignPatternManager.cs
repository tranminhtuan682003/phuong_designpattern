namespace phuong.baocao;

public class SingletonPattern : IDesignPattern
{
    public void Run()
    {
        GameManager.Instance.StartGame();
        GameManager.Instance.AddScore(10);
        GameManager.Instance.PauseGame();
        GameManager.Instance.ResumeGame();
        GameManager.Instance.AddScore(20);
        GameManager.Instance.EndGame();
    }
}

public class FactoryPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Factory Pattern...");

        // Yêu cầu người dùng nhập loại nhân vật
        Console.WriteLine("Enter character type (warrior, mage, archer):");
        string? characterType = Console.ReadLine();

        try
        {
            // Tạo nhân vật bằng cách sử dụng Factory
            ICharacter character = CharacterFactory.CreateCharacter(characterType ?? "");

            // Gọi phương thức Attack() của nhân vật
            character.Attack();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


public class BuilderPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Builder Pattern...");

        Character warrior = new CharacterBuilder()
            .SetName("Warrior")
            .SetAttackPower(20)
            .SetDefense(15)
            .SetHealth(150)
            .Build();

        Character mage = new CharacterBuilder()
            .SetName("Mage")
            .SetAttackPower(5)
            .SetHealth(80)
            .SetMagic(50)
            .Build();

        warrior.DisplayStats();
        mage.DisplayStats();
    }
}


public class PrototypePattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Prototype Pattern...");

        // Tạo nhân vật mẫu (prototype)
        GameCharacter warriorPrototype = new GameCharacter("Warrior", 20, 15, 100);
        warriorPrototype.DisplayStats();

        // Sao chép nhân vật mẫu để tạo nhân vật mới
        GameCharacter clonedWarrior = (GameCharacter)warriorPrototype.Clone();
        clonedWarrior.Name = "Warrior Clone";
        clonedWarrior.Health = 120; // Điều chỉnh một vài thuộc tính
        clonedWarrior.DisplayStats();

        // Tạo thêm bản sao khác từ prototype
        GameCharacter anotherWarriorClone = (GameCharacter)warriorPrototype.Clone();
        anotherWarriorClone.Name = "Warrior Clone 2";
        anotherWarriorClone.AttackPower = 25;
        anotherWarriorClone.DisplayStats();
    }
}

public class AdapterPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Adapter Pattern...");

        // Tạo đối tượng OldAudioSystem và Adapter
        OldAudioSystem oldAudioSystem = new OldAudioSystem();
        ISoundPlayer soundPlayer = new AudioAdapter(oldAudioSystem);

        // Sử dụng các phương thức của adapter
        soundPlayer.PlaySound();
        soundPlayer.StopSound();
    }
}


public class ObserverPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Observer Pattern...");

        // Tạo hệ thống sức khỏe và các observer
        HealthSystem healthSystem = new HealthSystem(100);
        HealthDisplay healthDisplay = new HealthDisplay();
        SoundAlarm soundAlarm = new SoundAlarm();

        // Đăng ký observer
        healthSystem.Attach(healthDisplay);
        healthSystem.Attach(soundAlarm);

        // Thay đổi sức khỏe và tự động cập nhật observer
        healthSystem.SetHealth(80);
        healthSystem.SetHealth(50);
        healthSystem.SetHealth(20); // Cảnh báo sẽ được kích hoạt
    }
}

public class CommandPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Command Pattern...");

        Player player = new Player();
        Invoker invoker = new Invoker();

        // Tạo các lệnh và thêm chúng vào invoker
        invoker.SetCommand(new MoveLeftCommand(player));
        invoker.SetCommand(new JumpCommand(player));
        invoker.SetCommand(new AttackCommand(player));
        invoker.SetCommand(new MoveRightCommand(player));

        // Thực thi các lệnh
        invoker.ExecuteCommands();
    }
}

public class StatePattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running State Pattern...");

        // Tạo nhân vật với trạng thái ban đầu là Idle
        CharacterS character = new CharacterS(new IdleState());
        character.PerformAction();

        // Chuyển đổi trạng thái và thực hiện hành động
        character.SetState(new MovingState());
        character.PerformAction();

        character.SetState(new AttackingState());
        character.PerformAction();
    }
}

public class StrategyPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Strategy Pattern...");

        // Tạo nhân vật với chiến lược tấn công ban đầu là SwordAttack
        CharacterStrategy character = new CharacterStrategy(new SwordAttack());
        character.PerformAttack();

        // Thay đổi chiến lược tấn công
        character.SetAttackStrategy(new MagicAttack());
        character.PerformAttack();

        character.SetAttackStrategy(new BowAttack());
        character.PerformAttack();
    }
}


public class TemplateMethodPattern : IDesignPattern
{
    public void Run()
    {
        Console.WriteLine("Running Template Method Pattern...");

        Quest collectQuest = new CollectQuest();
        collectQuest.ExecuteQuest();

        Quest battleQuest = new BattleQuest();
        battleQuest.ExecuteQuest();
    }
}





