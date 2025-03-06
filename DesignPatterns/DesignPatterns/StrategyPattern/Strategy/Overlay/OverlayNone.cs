using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("None");
    }
}
