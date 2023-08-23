Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);

Console.WriteLine("Client code is using the Adapter:");
adapter.Request();

// Existing interface that the client code expects to use
interface ITarget
{
    void Request();
}

// Existing class that needs to be adapted to the ITarget interface
class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's specific request is called.");
    }
}

// Adapter class that adapts Adaptee to ITarget interface
class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}