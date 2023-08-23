Context context = new Context(new ConcreteStrategyA());

context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

// Strategy
interface IStrategy
{
    void Execute();
}

// Concrete Strategies
class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing strategy A.");
    }
}

class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing strategy B.");
    }
}

// Context
class Context
{
    private IStrategy strategy;

    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        strategy.Execute();
    }
}