using System;

namespace DesignPatterns.Behavioural.TemplatePattern;

public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brew Tea");
    }
}
