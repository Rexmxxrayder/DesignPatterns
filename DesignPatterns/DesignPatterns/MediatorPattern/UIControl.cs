using System;

namespace DesignPatterns.DesignPatterns.MediatorPattern;

public class UIControl
{
    protected DialogBox _owner;

    public UIControl(DialogBox owner){
        _owner = owner;
    }
}
