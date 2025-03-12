using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern;

public class Logger : Handler
{
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Logging");
        return false;
    }
}
