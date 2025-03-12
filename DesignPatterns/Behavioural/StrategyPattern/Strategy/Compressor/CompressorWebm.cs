using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class CompressorWebm : ICompressor
{
    public void Compress()
    {
        Console.Write("Webm");
    }
}
