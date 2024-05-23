using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("purple",5));
        shapes.Add(new Rectangle("green",5,6));
        shapes.Add(new Circle("yellow",4));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.CalculateArea());
        }
        


    }
}