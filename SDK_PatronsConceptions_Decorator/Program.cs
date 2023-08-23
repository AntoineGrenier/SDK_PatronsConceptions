ICar basicCar = new BasicCar();
Console.WriteLine("Basic Car:");
Console.WriteLine($"Description: {basicCar.GetDescription()}");
Console.WriteLine($"Cost: {basicCar.GetCost()}");

ICar sportsCar = new SportsCar(new BasicCar());
Console.WriteLine("\nSports Car:");
Console.WriteLine($"Description: {sportsCar.GetDescription()}");
Console.WriteLine($"Cost: {sportsCar.GetCost()}");

// Component
interface ICar
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
class BasicCar : ICar
{
    public string GetDescription()
    {
        return "Basic Car";
    }

    public double GetCost()
    {
        return 20000;
    }
}

// Decorator
abstract class CarDecorator : ICar
{
    protected ICar car;

    public CarDecorator(ICar car)
    {
        this.car = car;
    }

    public abstract string GetDescription();

    public virtual double GetCost()
    {
        return car.GetCost();
    }
}

// Concrete Decorator
class SportsCar : CarDecorator
{
    public SportsCar(ICar car) : base(car)
    {
    }

    public override string GetDescription()
    {
        return car.GetDescription() + ", Sports Car";
    }

    public override double GetCost()
    {
        return car.GetCost() + 15000;
    }
}