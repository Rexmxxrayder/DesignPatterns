using System;

namespace DesignPatterns.Structural.BridgePattern;

public class LGRadio : Device
{
    public void SetChannel(int channel)
    {
        Console.WriteLine("SetChannel LG");
    }

    public void TurnOff()
    {
        Console.WriteLine("TurnOff LG");
    }

    public void TurnOn()
    {
        Console.WriteLine("TurnOn LG");
    }
}
