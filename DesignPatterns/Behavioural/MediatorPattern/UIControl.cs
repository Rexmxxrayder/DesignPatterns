using System;

namespace DesignPatterns.Behavioural.MediatorPattern;

public class UIControl
{
    protected DialogBox _owner;

    public UIControl(DialogBox owner){
        _owner = owner;
    }
}
