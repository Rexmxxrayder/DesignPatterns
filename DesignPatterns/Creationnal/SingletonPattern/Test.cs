using System;

namespace DesignPatterns.Creationnal.SingletonPattern;

public class Test
{
    public static void Run(){
        AppSettings.GetInstance().Set("cc", "cc");
        Console.WriteLine(AppSettings.GetInstance().Get("cc"));
    }
}
