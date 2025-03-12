using System;

namespace DesignPatterns.Structural.DecoratorPattern;

public class CompressionDecorator : DataDecorator
{
    public CompressionDecorator(Data data) : base(data)
    {
    }

    public override void Save(string data)
    {
        Console.WriteLine("CompressingData");
        _data.Save(Compress(data));
    }

    public string Compress(string data)
    {
        return data.Substring(9);
    }
}
