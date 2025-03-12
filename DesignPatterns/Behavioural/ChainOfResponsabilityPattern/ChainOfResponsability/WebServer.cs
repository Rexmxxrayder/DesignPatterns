using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern.ChainOfResponsability;

public class WebServer
{
    private Handler _handler;

    public WebServer(Handler handler){
        _handler = handler;
    }

    public void Handle(HttpRequest request){
        _handler.Handle(request);
    }
}
