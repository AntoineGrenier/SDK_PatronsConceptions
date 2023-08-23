Originator originator = new Originator();
originator.State = "State 1";

Caretaker caretaker = new Caretaker();
caretaker.Memento = originator.SaveState();

originator.State = "State 2";

originator.RestoreState(caretaker.Memento);

// Memento
class Memento
{
    private string state;

    public Memento(string state)
    {
        this.state = state;
    }

    public string State => state;
}

// Originator
class Originator
{
    private string state;

    public string State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine($"State set to: {state}");
        }
    }

    public Memento SaveState()
    {
        return new Memento(state);
    }

    public void RestoreState(Memento memento)
    {
        state = memento.State;
        Console.WriteLine($"State restored to: {state}");
    }
}

// Caretaker
class Caretaker
{
    public Memento Memento { get; set; }
}