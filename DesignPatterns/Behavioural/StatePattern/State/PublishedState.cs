using System;

namespace DesignPatterns.StatePattern.State;

public class PublishedState : State
{

    private Document _document;

    public PublishedState(Document document){
        _document = document;
    }

    public void Publish()
    {
        return;
    }
}
