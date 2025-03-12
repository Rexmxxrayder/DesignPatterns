using System;

namespace DesignPatterns.Creationnal.PrototypePattern;

public class ShapeActions
{
    public void Duplicate(Shape shape)
    {
        Shape newShape = shape.Duplicate();
        newShape.Draw();
    }
}
