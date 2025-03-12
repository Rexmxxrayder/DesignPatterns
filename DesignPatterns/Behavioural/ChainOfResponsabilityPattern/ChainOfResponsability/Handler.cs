using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern;

public abstract class Handler
{
    private Handler _nextHandler;

    public Handler SetNextHandler(Handler nextHandler){
        _nextHandler = nextHandler;
        return _nextHandler;
    }

    public void Handle(HttpRequest request){
        if(DoHandle(request)){
            return;
        }

        if (_nextHandler != null){
            _nextHandler.Handle(request);
        }
    }

    protected abstract bool DoHandle(HttpRequest request);
}
