using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public interface ViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}
