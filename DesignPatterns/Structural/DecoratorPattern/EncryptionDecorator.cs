using System;

namespace DesignPatterns.Structural.DecoratorPattern;

public class EncryptionDecorator : DataDecorator
{
    public EncryptionDecorator(Data data) : base(data)
    {
    }

    public override void Save(string data)
    {
        _data.Save(Encrypt(data));
    }

    public string Encrypt(string data)
    {
        return "feg5g87eg4r78";
    }
}
