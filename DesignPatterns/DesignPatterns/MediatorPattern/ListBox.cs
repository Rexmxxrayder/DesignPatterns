using System;

namespace DesignPatterns.DesignPatterns.MediatorPattern;

public class ListBox : UIControl
{
    private string _selection = "";
    public string Selection => _selection;

    public ListBox(DialogBox owner) : base(owner){

    }

    public void SetSelection(string selection){
        _selection = selection;
        _owner.Changed(this);
    }
}
