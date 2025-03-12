using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern;

public class Validator : Handler
{
    protected override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Validating");
        request.ValidatedUsername = request.Username;
        request.ValidatedPassword = request.Password;

        return request.ValidatedUsername == "" || request.ValidatedPassword == "";
    }
}
