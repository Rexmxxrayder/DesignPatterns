using System;
using System.Data.Common;

namespace DesignPatterns.Behavioural.ObserverPattern;

public class BarChart : IObserver
{
    private DataSource _dataSource;

    public BarChart(DataSource dataSource){
        _dataSource = dataSource;
    }
    public void Update()
    {
        Console.Write("\nBarchart");
    }
}
