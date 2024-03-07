using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("White",12);
        Rectangle rectangle = new Rectangle("Red",12,16);
        Circle circle = new Circle("Blue",12);
        
        double squareArea = square.GetArea();
        double rectangleArea = rectangle.GetArea();
        double circleArea = circle.GetArea();

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        Console.WriteLine(shapes[0].GetArea());
    }
}