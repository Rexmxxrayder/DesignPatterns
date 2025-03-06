using System;

namespace DesignPatterns.Patterns.Memento;

public class EditorState
{
    private readonly string _title;
    private readonly string _content;

    private readonly DateTime _stateCreatedAt;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedAt = DateTime.UtcNow;
    }

    public string Title => _title;
    public string Content => _content;
    public DateTime Date => _stateCreatedAt;

    public string Name => $"{_stateCreatedAt} / {_title}";

}
