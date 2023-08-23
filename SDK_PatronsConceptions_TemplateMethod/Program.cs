AbstractClass classA = new ConcreteClassA();
classA.TemplateMethod();

AbstractClass classB = new ConcreteClassB();
classB.TemplateMethod();

// Abstract Class
abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Operation1();
        Operation2();
    }

    protected abstract void Operation1();
    protected abstract void Operation2();
}

// Concrete Class
class ConcreteClassA : AbstractClass
{
    protected override void Operation1()
    {
        Console.WriteLine("ConcreteClassA: Operation1");
    }

    protected override void Operation2()
    {
        Console.WriteLine("ConcreteClassA: Operation2");
    }
}

class ConcreteClassB : AbstractClass
{
    protected override void Operation1()
    {
        Console.WriteLine("ConcreteClassB: Operation1");
    }

    protected override void Operation2()
    {
        Console.WriteLine("ConcreteClassB: Operation2");
    }
}