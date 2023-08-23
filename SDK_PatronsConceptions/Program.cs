ShapeFactory factory = new ShapeFactory();

Shape circle = factory.CreateShape("circle");
circle.Draw();

Shape rectangle = factory.CreateShape("rectangle");
rectangle.Draw();


abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class ShapeFactory
{
    public Shape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                return new Circle();
            case "rectangle":
                return new Rectangle();
            default:
                throw new ArgumentException("Invalid shape type");
        }
    }
}