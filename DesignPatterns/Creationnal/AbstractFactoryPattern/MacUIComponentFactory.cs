using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class MacUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new MacUIButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacUICheckbox();
    }
}
