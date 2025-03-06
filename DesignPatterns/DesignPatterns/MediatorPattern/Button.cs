using System;

namespace DesignPatterns.DesignPatterns.MediatorPattern;

public class Button : UIControl
{
    private bool _isEnabled;

    public bool IsEnabled => _isEnabled;

    public Button(DialogBox owner) : base(owner)
    {

    }

    public void SetEnabled(bool isEnabled)
    {
        _isEnabled = isEnabled;
        _owner.Changed(this);
    }

}
