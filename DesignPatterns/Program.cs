using DesignPatterns.DesignPatterns.CommandPattern;
using DesignPatterns.DesignPatterns.CommandPattern.Command;

Light light = new();
RemoteControl remoteControl= new(new TurnOnCommand(light));
remoteControl.PressButton();
remoteControl.SetCommand(new TurnDimCommand(light));
remoteControl.PressButton();
remoteControl.SetCommand(new TurnOffCommand(light));
remoteControl.PressButton();