using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class OverlayBlackAndWhite : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("BlackAndWhite");
    }
}
