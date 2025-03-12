using System;

namespace DesignPatterns.Structural.BridgePattern;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(Device device) : base(device)
    {

    }

    public void SetChannel(int channel)
    {
        _device.SetChannel(channel);
        Console.WriteLine("Setting channel to " + channel);
    }
}
