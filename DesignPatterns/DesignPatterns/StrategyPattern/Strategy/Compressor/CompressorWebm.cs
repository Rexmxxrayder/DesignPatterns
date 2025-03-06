using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class CompressorWebm : ICompressor
{
    public void Compress()
    {
        Console.Write("Webm");
    }
}
