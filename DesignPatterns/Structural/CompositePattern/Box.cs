using System;

namespace DesignPatterns.Structural.CompositePattern;

public class Box : Item
{
    public List<Item> _items = new();

    public void Add(Item item){
        _items.Add(item);
    }

    public float GetPrice()
    {
        float total = 0f;
        foreach(Item item in _items){
            total += item.GetPrice();
        }

        return total;
    }
}
