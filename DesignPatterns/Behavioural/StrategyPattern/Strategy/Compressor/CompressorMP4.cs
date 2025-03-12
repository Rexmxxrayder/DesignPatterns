using System;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class CompressorMP4 : ICompressor
{
        public void Compress()
    {
        Console.Write("MP4");
    }
}
