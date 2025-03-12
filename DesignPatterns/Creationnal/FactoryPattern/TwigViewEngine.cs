using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public class TwigViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View renderer Twig";
    }
}
