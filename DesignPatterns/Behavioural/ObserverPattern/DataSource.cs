using System;

namespace DesignPatterns.Behavioural.ObserverPattern;

public class DataSource : Subject
{
    private List<int> _values;

    public List<int> Values => _values;

    public void SetValues(List<int> values)
    {
        _values = values;

        NotifyObservers();
    }
}
