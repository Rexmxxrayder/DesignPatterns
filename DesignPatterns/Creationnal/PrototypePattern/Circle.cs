using System;

namespace DesignPatterns.Creationnal.PrototypePattern;

public class Circle : Shape
{
    private float _radius;
    public float Radius {get { return _radius;} set { _radius = value; } }
    public override void Draw()
    {
        Console.WriteLine("Draw Circle");
    }

    public override Shape Duplicate()
    {
        Circle newCircle = new();
        newCircle.Radius = _radius;
        return newCircle;
    }
}
