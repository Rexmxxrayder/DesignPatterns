using System;

namespace DesignPatterns.Behavioural.VisitorPattern;

public abstract class Client
{
    private string _name;
    private string _email;

    public string Name => _name;

    public Client(string name, string email){
        _name = name;
        _email = email;
    }

    public abstract void Accept(Visitor visitor);
}
