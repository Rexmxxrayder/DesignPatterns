using System;

namespace DesignPatterns.Structural.BridgePattern;

public class RemoteControl
{
    protected Device _device;

    public RemoteControl(Device device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }
}
