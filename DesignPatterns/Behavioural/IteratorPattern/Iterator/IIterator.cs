using System;

namespace DesignPatterns.Behavioural.IteratorPattern;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}
