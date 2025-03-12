using System;

namespace DesignPatterns.Structural.BridgePattern;

public interface Device
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
}
