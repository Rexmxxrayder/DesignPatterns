using System;

namespace DesignPatterns.Creationnal.AbstractFactoryPattern;

public class UserSettingsForm
{
    public void Render(IUIComponentFactory uIComponentFactory){
        uIComponentFactory.CreateButton().Render();
        uIComponentFactory.CreateCheckbox().Render();
    }
}
