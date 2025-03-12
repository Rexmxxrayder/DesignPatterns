using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Blur");
    }
}
