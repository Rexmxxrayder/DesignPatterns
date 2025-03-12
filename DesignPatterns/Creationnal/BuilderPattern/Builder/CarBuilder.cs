using System;

namespace DesignPatterns.Creationnal.BuilderPattern.Builder;

public class CarBuilder : IBuilder
{
    private Car _car;

    public CarBuilder()
    {
        Reset();
    }
    public IBuilder IsConvertible(bool isConvertible)
    {
        _car.IsConvertible = isConvertible;
        return this;
    }

    public void Reset()
    {
        _car = new Car();
    }

    public IBuilder SetCarType(string carType)
    {
        _car.Type = carType;
        return this;
    }

    public IBuilder SetDashboard(string dashboard)
    {
        _car.Dashboard = dashboard;
        return this;
    }

    public IBuilder SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public IBuilder SetGPSNavigator(string gpsNavigator)
    {
        _car.GPSNavigator = gpsNavigator;
        return this;
    }

    public IBuilder SetSeats(int seats)
    {
        _car.Seats = seats;
        return this;
    }

    public IBuilder SetWheels(string wheels)
    {
        _car.Wheels = wheels;
        return this;
    }
}
