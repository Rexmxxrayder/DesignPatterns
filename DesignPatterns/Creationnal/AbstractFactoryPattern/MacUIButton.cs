using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class MacUIButton : IButton
{
    public void Render()
    {
        Console.WriteLine("MacUIButton");
    }
}
