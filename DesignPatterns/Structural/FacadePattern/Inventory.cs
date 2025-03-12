using System;

namespace DesignPatterns.Structural.FacadePattern;

public class Inventory
{
    public bool CheckInventory(string itemId){
        return true;
    }

    public void ReduceInventory(string ItemId, int amount){
        Console.WriteLine("Reducing inventory of " + ItemId + " by " + amount);
    }
}
