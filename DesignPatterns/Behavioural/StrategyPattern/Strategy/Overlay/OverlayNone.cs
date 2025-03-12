using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("None");
    }
}
