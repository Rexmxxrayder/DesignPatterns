using System;
using DesignPatterns.Behavioural.MediatorPattern.Mediator;

namespace DesignPatterns.Behavioural.MediatorPattern;

public class PostsDialogBox : DialogBox
{
    private ListBox _listBox;
    private TextBox _textBox;
    private Button _saveButton;

    public PostsDialogBox()
    {
        _listBox = new ListBox(this);
        _textBox = new TextBox(this);
        _saveButton = new Button(this);
        _saveButton.SetEnabled(false);
    }

    public override void Changed(UIControl uiControl)
    {
        if (uiControl == _listBox)
        {
            HandlePostChanged();
        }
        else if (uiControl == _textBox)
        {
            HandleTitleChanged();
        }
    }

    public void SimulateUserInteraction(){
        _listBox.SetSelection("Post 2");
        _textBox.SetText("");
        Console.WriteLine("Title text box: " + _textBox.Text);
        Console.WriteLine("Button is " + _saveButton.IsEnabled);
    }

    private void HandlePostChanged()
    {
        _textBox.SetText(_listBox.Selection);
        _saveButton.SetEnabled(true);
    }

    private void HandleTitleChanged()
    {
        bool isTitleEmpty = _textBox.Text == "";
        _saveButton.SetEnabled(!isTitleEmpty);
    }
}
