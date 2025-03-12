using System;

namespace DesignPatterns.Structural.AdapterPattern;

public class RainbowColor : Color
{
    private Rainbow _rainbow;

    public RainbowColor(Rainbow rainbow){
        _rainbow = rainbow;
    }

    public void Apply(Video video){
        _rainbow.Setup();
        _rainbow.Update(video);
    }
}
