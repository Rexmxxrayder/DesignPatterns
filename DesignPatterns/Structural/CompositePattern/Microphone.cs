using System;

namespace DesignPatterns.Structural.CompositePattern;

public class Microphone : Item
{
    private float _price = 23.00f;

    public float GetPrice()
    {
        return _price;
    }
}
