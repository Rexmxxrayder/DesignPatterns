using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern;

public class Authentificator : Handler
{
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Authentificating");
        return !(request.Username == "danny" && request.Password == "12345678");
    }
}
