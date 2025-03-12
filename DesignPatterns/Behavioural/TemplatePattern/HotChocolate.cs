using System;

namespace DesignPatterns.Behavioural.TemplatePattern;

public class HotChocolate : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brew hot Chocolate");
    }
}
