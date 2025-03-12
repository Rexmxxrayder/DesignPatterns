using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class WindowsUICheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("WindowsUICheckbox");
    }
}
