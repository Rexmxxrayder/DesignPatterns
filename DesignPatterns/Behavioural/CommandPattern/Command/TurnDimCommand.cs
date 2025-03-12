using System;

namespace DesignPatterns.Behavioural.CommandPattern.Command;

public class TurnDimCommand : ICommand
{
    private Light _light;

    public TurnDimCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Dim();
    }
}
