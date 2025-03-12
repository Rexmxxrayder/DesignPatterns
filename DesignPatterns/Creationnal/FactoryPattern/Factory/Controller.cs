using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public class Controller
{
    public void Render(string fileName, Dictionary<string, object> data){
        var viewEngine = CreateViewEngine();
        var html = viewEngine.Render(fileName, data);
        Console.WriteLine(html);
    }

    protected virtual ViewEngine CreateViewEngine(){
        return new BladeViewEngine();
    }
}
