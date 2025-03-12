using System;

namespace DesignPatterns.Structural.BridgePattern;

public class SonyRadio : Device
{
    public void SetChannel(int channel)
    {
        Console.WriteLine("SetChannel Sony");
    }

    public void TurnOff()
    {
        Console.WriteLine("TurnOff Sony");
    }

    public void TurnOn()
    {
        Console.WriteLine("TurnOn Sony");
    }
}
