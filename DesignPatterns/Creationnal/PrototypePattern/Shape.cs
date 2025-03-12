using System;

namespace DesignPatterns.Creationnal.PrototypePattern;

public abstract class Shape
{
    public abstract void Draw();
    public abstract Shape Duplicate();
}
