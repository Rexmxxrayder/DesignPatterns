using System;

namespace DesignPatterns.Behavioural.TemplatePattern;

public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brew Coffee");
    }

    protected override void AddCondiments(){
        Console.WriteLine("Add sugar");
    }
}
