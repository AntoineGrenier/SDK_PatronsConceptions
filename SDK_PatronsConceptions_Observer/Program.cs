ConcreteSubject subject = new ConcreteSubject();
IObserver observer1 = new ConcreteObserver("Observer 1");
IObserver observer2 = new ConcreteObserver("Observer 2");

subject.Attach(observer1);
subject.Attach(observer2);

subject.Notify("Hello, observers!");

// Observer
interface IObserver
{
    void Update(string message);
}

// Concrete Observer
class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

// Subject
interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

// Concrete Subject
class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}