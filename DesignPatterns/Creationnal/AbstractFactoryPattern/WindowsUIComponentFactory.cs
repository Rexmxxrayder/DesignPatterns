using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class WindowsUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new WindowsUIButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsUICheckbox();
    }
}
