ObjectStructure structure = new ObjectStructure();
structure.Attach(new ElementA());
structure.Attach(new ElementB());

IVisitor visitor = new ConcreteVisitor();

structure.Accept(visitor);

// Visitor
interface IVisitor
{
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
}

// Concrete Visitor
class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        Console.WriteLine($"ConcreteVisitor visits {elementA.GetType().Name}");
    }

    public void Visit(ElementB elementB)
    {
        Console.WriteLine($"ConcreteVisitor visits {elementB.GetType().Name}");
    }
}

// Element
interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete Elements
class ElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

class ElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

// Object Structure
class ObjectStructure
{
    private List<IElement> elements = new List<IElement>();

    public void Attach(IElement element)
    {
        elements.Add(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}