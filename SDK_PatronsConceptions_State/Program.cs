Context context = new Context(new ConcreteStateA());

context.Request();
context.Request();
context.Request();

// State
interface IState
{
    void Handle(Context context);
}

// Concrete States
class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Handling state A.");
        context.State = new ConcreteStateB();
    }
}

class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Handling state B.");
        context.State = new ConcreteStateA();
    }
}

// Context
class Context
{
    private IState state;

    public Context(IState state)
    {
        this.state = state;
    }

    public IState State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine($"Current state: {state.GetType().Name}");
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}