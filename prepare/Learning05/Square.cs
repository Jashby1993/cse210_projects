using System;
public class Square : Shape
{
    private double _side;

    public Square(string color, double side)
    {
        _color = color;
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double CalculateArea()
    {
        double area = _side * _side;
        return area;
    }
}