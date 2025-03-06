using System;

namespace DesignPatterns.DesignPatterns.StrategyPattern;

public class CompressorMP4 : ICompressor
{
        public void Compress()
    {
        Console.Write("MP4");
    }
}
