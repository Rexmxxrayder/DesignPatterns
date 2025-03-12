using System;

namespace DesignPatterns.Creationnal.BuilderPattern.Builder;

public class ManualBuilder : IBuilder
{
    private Manual _manual;

    public ManualBuilder()
    {
        Reset();
    }
    public IBuilder IsConvertible(bool isConvertible)
    {
        _manual.IsConvertible = isConvertible;
        return this;
    }

    public void Reset()
    {
        _manual = new Manual();
    }

    public IBuilder SetCarType(string carType)
    {
        _manual.Type = carType;
        return this;
    }

    public IBuilder SetDashboard(string dashboard)
    {
        _manual.Dashboard = dashboard;
        return this;
    }

    public IBuilder SetEngine(string engine)
    {
        _manual.Engine = engine;
        return this;
    }

    public IBuilder SetGPSNavigator(string gpsNavigator)
    {
        _manual.GPSNavigator = gpsNavigator;
        return this;
    }

        public IBuilder SetSeats(int seats)
    {
        _manual.Seats = seats;
        return this;
    }


    public IBuilder SetWheels(string wheels)
    {
        _manual.Wheels = wheels;
        return this;
    }
}
