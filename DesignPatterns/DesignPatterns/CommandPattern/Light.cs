using System;

namespace DesignPatterns.DesignPatterns.CommandPattern;

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("TurnOn");
    }

    public void TurnOff()
    {
        Console.WriteLine("TurnOff");
    }

    public void Dim()
    {
        Console.WriteLine("Dim");
    }
}
