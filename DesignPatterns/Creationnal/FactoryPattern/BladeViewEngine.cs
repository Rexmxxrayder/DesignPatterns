using System;
using System.Security.Cryptography.X509Certificates;

namespace DesignPatterns.Creationnal.BuilderPattern;

public class BladeViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View renderer Blade";
    }
}
