using System.Collections;

ConcreteAggregate aggregate = new ConcreteAggregate();
aggregate.AddItem("Item 1");
aggregate.AddItem("Item 2");
aggregate.AddItem("Item 3");

IIterator iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.CurrentItem());
    iterator.Next();
}

// Aggregate
interface IAggregate
{
    IIterator CreateIterator();
}

// Concrete Aggregate
class ConcreteAggregate : IAggregate
{
    private ArrayList items = new ArrayList();

    public void AddItem(object item)
    {
        items.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count => items.Count;

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

// Iterator
interface IIterator
{
    object CurrentItem();
    bool HasNext();
    void Next();
}

// Concrete Iterator
class ConcreteIterator : IIterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public object CurrentItem()
    {
        return aggregate[current];
    }

    public bool HasNext()
    {
        return current < aggregate.Count;
    }

    public void Next()
    {
        current++;
    }
}