using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class MacUICheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("MacUICheckbox");
    }
}
