using System;

namespace DesignPatterns.Structural.AdapterPattern;

public class Rainbow
{
    public void Setup(){
        Console.WriteLine("Setting up rainbow filter");
    }

    public void Update(Video video){
        Console.WriteLine("Applying rainbow filter to video");
    }
}
