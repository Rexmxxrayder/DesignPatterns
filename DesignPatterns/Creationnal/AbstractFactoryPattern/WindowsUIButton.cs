using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class WindowsUIButton : IButton
{
    public void Render()
    {
        Console.WriteLine("WindowsUIButton");
    }
}
