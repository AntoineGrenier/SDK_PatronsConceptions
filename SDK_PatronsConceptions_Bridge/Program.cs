Shape[] shapes = new Shape[]
{
    new Circle(1, 2, 3, new DrawingAPI1()),
    new Circle(5, 7, 11, new DrawingAPI2())
};

foreach (var shape in shapes)
{
    shape.Draw();
}

// Abstraction
abstract class Shape
{
    protected IDrawingAPI drawingAPI;

    protected Shape(IDrawingAPI drawingAPI)
    {
        this.drawingAPI = drawingAPI;
    }

    public abstract void Draw();
}

// Concrete Abstraction
class Circle : Shape
{
    private double x, y, radius;

    public Circle(double x, double y, double radius, IDrawingAPI drawingAPI) : base(drawingAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
        drawingAPI.DrawCircle(x, y, radius);
    }
}

// Implementor
interface IDrawingAPI
{
    void DrawCircle(double x, double y, double radius);
}

// Concrete Implementor
class DrawingAPI1 : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius)
    {
        Console.WriteLine($"Drawing API 1 - Circle at ({x}, {y}) with radius {radius}");
    }
}

class DrawingAPI2 : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius)
    {
        Console.WriteLine($"Drawing API 2 - Circle at ({x}, {y}) with radius {radius}");
    }
}