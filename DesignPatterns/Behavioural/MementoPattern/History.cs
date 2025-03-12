using System;

namespace DesignPatterns.Patterns.Memento;

public class History
{
    public List<EditorState> _states = [];
    private Editor _editor;

    public History(Editor editor){
        _editor = editor;
    }

    public void Backup(){
        _states.Add(_editor.CreateState());
    }

    public void Undo(){
        if(_states.Count == 0){
            return;
        }

        EditorState prevState = _states.Last();
        _states.Remove(prevState);

        _editor.Restore(prevState);
    }

    public void ShowHistory(){
        Console.WriteLine("\nHistory: Here's is the list of mementos:");

        foreach(var state in _states){
            Console.WriteLine(state.Name);
        }
    }

}
