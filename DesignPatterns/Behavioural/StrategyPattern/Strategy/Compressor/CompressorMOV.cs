using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        Console.Write("MOV");
    }
}
