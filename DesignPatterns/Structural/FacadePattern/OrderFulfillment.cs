using System;

namespace DesignPatterns.Structural.FacadePattern;

public class OrderFulfillment
{
    private Inventory _inventory;

    public OrderFulfillment(Inventory inventory){
        _inventory = inventory;
    }

    public void Fullfill(string name, string address, string[] items){
        Console.WriteLine("Inserting order into database");
        foreach (var item in items){
            _inventory.ReduceInventory(item, 1);
        }
    }
}
