using System;

namespace DesignPatterns.DesignPatterns.IteratorPattern;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}
