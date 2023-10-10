using System;

class Square : Shape
{
    private double _side;

    public class Square(string color, double side) : base(color)
    {
        _color = color;
        _side = side;
        GetSide();
        GetArea();
    }

    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    
}