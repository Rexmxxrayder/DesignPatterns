using System;

namespace DesignPatterns.Patterns.Memento;

public class Editor
{
    public string Title {get; set;}
    public string Content {get; set;}

    public Editor(){
        Title = "";
        Content = "";
    }

    public EditorState CreateState(){
        return new EditorState(Title, Content);
    }

    public void Restore(EditorState state) {
        Title = state.Title;
        Content = state.Content;
    }
}
