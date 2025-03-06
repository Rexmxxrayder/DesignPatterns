using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class OverlayBlackAndWhite : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("BlackAndWhite");
    }
}
