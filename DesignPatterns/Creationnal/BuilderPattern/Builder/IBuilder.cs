using System;

namespace DesignPatterns.Creationnal.BuilderPattern;

public interface IBuilder
{
    void Reset();
    IBuilder SetCarType(string carType);
    IBuilder SetSeats(int Seats);
    IBuilder IsConvertible(bool isConvertible);
    IBuilder SetEngine(string engine);
    IBuilder SetWheels(string wheels);
    IBuilder SetDashboard(string dashboard);
    IBuilder SetGPSNavigator(string gpsNavigator);
}
