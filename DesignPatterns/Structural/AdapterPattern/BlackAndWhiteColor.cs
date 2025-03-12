using System;

namespace DesignPatterns.Structural.AdapterPattern;

public class BlackAndWhiteColor : Color
{
    public void Apply(Video video)
    {
        Console.WriteLine("Apply Black and White");
    }
}
