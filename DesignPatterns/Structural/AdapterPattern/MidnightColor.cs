using System;

namespace DesignPatterns.Structural.AdapterPattern;

public class MidnightColor : Color
{
    public void Apply(Video video)
    {
        Console.WriteLine("Apply Midnight Color");
    }
}
