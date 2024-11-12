using phuong.baocao;

public class Program
{
    private static readonly Dictionary<string, IDesignPattern> patterns = new()
    {
        { "singleton", new SingletonPattern() },
        { "factory", new FactoryPattern() },
        {"builder",new BuilderPattern()},
        {"prototype", new PrototypePattern()},
        {"adapter", new AdapterPattern()},
        {"observer", new ObserverPattern()},
        {"command", new CommandPattern()},
        {"state",new StatePattern()},
        {"strategy", new StrategyPattern()},
        {"template", new TemplateMethodPattern()}


    };

    public static void Main()
    {
        Console.WriteLine("Enter the name of the Design Pattern to run :");
        string? patternName = Console.ReadLine()?.ToLower();

        if (patterns.TryGetValue(patternName ?? "", out IDesignPattern? pattern))
        {
            pattern.Run();
        }
        else
        {
            Console.WriteLine("Pattern not found. Please check the name and try again.");
        }
    }
}
