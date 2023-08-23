Facade facade = new Facade();
facade.DoComplexWork();

// Subsystem
class Subsystem1
{
    public void Operation1()
    {
        Console.WriteLine("Subsystem 1: Operation 1");
    }
}

class Subsystem2
{
    public void Operation2()
    {
        Console.WriteLine("Subsystem 2: Operation 2");
    }
}

class Subsystem3
{
    public void Operation3()
    {
        Console.WriteLine("Subsystem 3: Operation 3");
    }
}

// Facade
class Facade
{
    private Subsystem1 subsystem1;
    private Subsystem2 subsystem2;
    private Subsystem3 subsystem3;

    public Facade()
    {
        subsystem1 = new Subsystem1();
        subsystem2 = new Subsystem2();
        subsystem3 = new Subsystem3();
    }

    public void DoComplexWork()
    {
        Console.WriteLine("Facade: Doing complex work by coordinating the subsystems:");
        subsystem1.Operation1();
        subsystem2.Operation2();
        subsystem3.Operation3();
    }
}