using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        Console.Write("MOV");
    }
}
