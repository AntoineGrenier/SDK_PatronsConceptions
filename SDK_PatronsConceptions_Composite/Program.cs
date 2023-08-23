var root = new Composite("Root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

var branch = new Composite("Branch");
branch.Add(new Leaf("Leaf X"));
branch.Add(new Leaf("Leaf Y"));

root.Add(branch);

root.Display();

// Component
interface IComponent
{
    void Display();
}

// Leaf
class Leaf : IComponent
{
    private string name;

    public Leaf(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine(name);
    }
}

// Composite
class Composite : IComponent
{
    private List<IComponent> children = new List<IComponent>();
    private string name;

    public Composite(string name)
    {
        this.name = name;
    }

    public void Add(IComponent component)
    {
        children.Add(component);
    }

    public void Display()
    {
        Console.WriteLine(name);
        foreach (var child in children)
        {
            child.Display();
        }
    }
}