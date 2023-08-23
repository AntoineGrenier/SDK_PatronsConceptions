ConcreteColleagueA colleagueA = new ConcreteColleagueA(null);
ConcreteColleagueB colleagueB = new ConcreteColleagueB(null);

ConcreteMediator mediator = new ConcreteMediator(colleagueA, colleagueB);

colleagueA.Send("Hello from Colleague A!");
colleagueB.Send("Hi from Colleague B!");

// Mediator
interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}

// Colleague
abstract class Colleague
{
    protected IMediator mediator;

    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void ReceiveMessage(string message);
}

// Concrete Colleagues
class ConcreteColleagueA : Colleague
{
    public ConcreteColleagueA(IMediator mediator) : base(mediator)
    {
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"Colleague A received: {message}");
    }

    public void Send(string message)
    {
        mediator.SendMessage(message, this);
    }
}

class ConcreteColleagueB : Colleague
{
    public ConcreteColleagueB(IMediator mediator) : base(mediator)
    {
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"Colleague B received: {message}");
    }

    public void Send(string message)
    {
        mediator.SendMessage(message, this);
    }
}

// Concrete Mediator
class ConcreteMediator : IMediator
{
    private ConcreteColleagueA colleagueA;
    private ConcreteColleagueB colleagueB;

    public ConcreteMediator(ConcreteColleagueA colleagueA, ConcreteColleagueB colleagueB)
    {
        this.colleagueA = colleagueA;
        this.colleagueB = colleagueB;
    }

    public void SendMessage(string message, Colleague colleague)
    {
        if (colleague == colleagueA)
        {
            colleagueB.ReceiveMessage(message);
        }
        else if (colleague == colleagueB)
        {
            colleagueA.ReceiveMessage(message);
        }
    }
}