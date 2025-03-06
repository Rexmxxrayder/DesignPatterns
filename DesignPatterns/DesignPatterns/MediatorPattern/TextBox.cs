using System;

namespace DesignPatterns.DesignPatterns.MediatorPattern.Mediator;

public class TextBox : UIControl
{
    private string _text = "";
    public string Text => _text;

    public TextBox(DialogBox owner) : base(owner)
    {
        
    }

    public void SetText(string text)
    {
        _text = text;
        _owner.Changed(this);
    }
}
