using System;

interface IShape
{
    void DisplayShapeType();
    void DisplayArea();
    double FirstDimension { get; set; }
}

interface IColoredShape : IShape
{
    string Color { get; set; }
    void DisplayColor();
}

class Circle : IShape
{
    public double FirstDimension { get; set; }

    public Circle(double radius)
    {
        FirstDimension = radius;
    }

    public void DisplayShapeType()
    {
        Console.WriteLine("Коло");
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Площа: {Math.PI * Math.Pow(FirstDimension, 2)}");
    }
}

class ColoredCircle : IColoredShape
{
    public double FirstDimension { get; set; }
    public string Color { get; set; }

    public ColoredCircle(double radius, string color)
    {
        FirstDimension = radius;
        Color = color;
    }

    public void DisplayShapeType()
    {
        Console.WriteLine("Коло з кольором");
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Площа: {Math.PI * Math.Pow(FirstDimension, 2)}");
    }

    public void DisplayColor()
    {
        Console.WriteLine($"Колір: {Color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle1 = new Circle(5);
        IShape circle2 = new Circle(10);
        IShape circle3 = new Circle(15);

        IColoredShape coloredCircle1 = new ColoredCircle(5, "Червоний");
        IColoredShape coloredCircle2 = new ColoredCircle(10, "Синій");
        IColoredShape coloredCircle3 = new ColoredCircle(15, "Зелений");

        IShape[] shapes = new IShape[] { circle1, circle2, circle3, coloredCircle1, coloredCircle2, coloredCircle3 };

        DisplayShapesInfo(shapes);

        Console.ReadLine();
    }

    static void DisplayShapesInfo(IShape[] shapes)
    {
        foreach (IShape shape in shapes)
        {
            shape.DisplayShapeType();
            shape.DisplayArea();

            if (shape is IColoredShape coloredShape)
            {
                coloredShape.DisplayColor();
            }

            Console.WriteLine();
        }
    }
}
