using System;

namespace DesignPatterns.Creationnal.PrototypePattern;

public class Rectangle : Shape
{
    private float _width;
    private float _height;
    public float Width { get { return _width; } set { _width = value; } }
    public float Height { get { return _height; } set { _height = value; } }
    public override void Draw()
    {
        Console.WriteLine("Draw Rectangle");
    }

        public override Shape Duplicate()
    {
        Rectangle newRectangle = new();
        newRectangle.Width = _width;
        newRectangle.Height = _height;
        return newRectangle;
    }
}
