using System;

namespace DesignPatterns.Structural.CompositePattern;

public class Keyboard : Item
{
    private float _price = 35.00f;

    public float GetPrice()
    {
        return _price;
    }
}
