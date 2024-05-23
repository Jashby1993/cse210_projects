using System;

public class Circle : Shape
{
double _radius;

public Circle(string color, double radius)
{
    _color = color;
    _radius = radius;
}

public double GetRadius()
{
    return _radius;
}
public void SetRadius(double radius)
{
    _radius = radius;
}

    public override double CalculateArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}