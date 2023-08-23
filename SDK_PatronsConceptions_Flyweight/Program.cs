RobotFactory factory = new RobotFactory();

IRobot robot1 = factory.GetRobot("Small");
robot1.Display();

IRobot robot2 = factory.GetRobot("Small");
robot2.Display();

Console.WriteLine($"Are the robots the same? {robot1 == robot2}");

// Flyweight
interface IRobot
{
    void Display();
}

// ConcreteFlyweight
class SmallRobot : IRobot
{
    private string robotType;

    public SmallRobot()
    {
        robotType = "Small Robot";
    }

    public void Display()
    {
        Console.WriteLine($"This is a {robotType}");
    }
}

// Flyweight Factory
class RobotFactory
{
    private Dictionary<string, IRobot> robots = new Dictionary<string, IRobot>();

    public IRobot GetRobot(string robotType)
    {
        if (!robots.ContainsKey(robotType))
        {
            robots.Add(robotType, new SmallRobot());
        }
        return robots[robotType];
    }
}