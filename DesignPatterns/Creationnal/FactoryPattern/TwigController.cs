using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public class TwigController : Controller
{
    protected override ViewEngine CreateViewEngine()
    {
        return new TwigViewEngine();
    }
}
