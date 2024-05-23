using System;
public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width)
    {
        _color = color;
        _length = length;
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
     public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

    public override double CalculateArea()
    {
        double area = _length * _width;
        return area;
    }
}