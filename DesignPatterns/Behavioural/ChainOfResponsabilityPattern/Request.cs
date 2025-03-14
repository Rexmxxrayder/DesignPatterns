using System;

namespace DesignPatterns.Behavioural.ChainOfResponsabilityPattern;

public class HttpRequest
{
    private string _username;
    private string _password;

    public string Username => _username;
    public string Password => _password;

    public string ValidatedUsername {get ; set; }
    public string ValidatedPassword {get ; set; }

    public HttpRequest(string username, string password){
        _username = username;
        _password = password;
    }
}
