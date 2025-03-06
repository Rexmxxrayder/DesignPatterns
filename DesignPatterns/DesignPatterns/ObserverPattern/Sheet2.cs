using System;

namespace DesignPatterns.DesignPatterns.ObserverPattern;

public class Sheet2 : IObserver
{
    private int _total;
    private DataSource _dataSource;

    public int Total => _total;

    public Sheet2(DataSource dataSource){
        _dataSource = dataSource;
    }
    public void Update()
    {
        _total = CalculateTotal(_dataSource.Values);
    }

    public int CalculateTotal(List<int> values)
    {
        int sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        Console.WriteLine(sum);
        return sum;
    }
}
