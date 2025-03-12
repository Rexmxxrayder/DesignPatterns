using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public interface IUIComponentFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
