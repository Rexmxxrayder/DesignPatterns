using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public class Car
{
    public string Type { get; set; }
    public int Seats { get; set; }
    public bool IsConvertible { get; set; }
    public string Engine { get; set; }
    public string Dashboard { get; set; }
    public string Wheels { get; set; }
    public string GPSNavigator { get; set; }

    public double Fuel { get; set; }
}
