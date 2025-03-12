using System;

namespace DesignPatterns.Structural.DecoratorPattern;

public class ClouData : Data
{
    protected string _url;

    public ClouData(string url)
    {
        _url = url;
    }

    public virtual void Save(string data)
    {
        Console.WriteLine($"Saving data {data} to cloud at {_url}");
    }
}
