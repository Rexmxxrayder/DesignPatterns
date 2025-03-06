using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Blur");
    }
}
