using System;
using System.ComponentModel;

namespace DesignPatterns.Behavioural.TemplatePattern;

public abstract class Beverage
{
    public void Prepare(){
        BoilWater();
        PourIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater(){
        Console.WriteLine("Boiling Water");
    }

    private void PourIntoCup(){
        Console.WriteLine("Pourinf into cup");
    }

    protected abstract void Brew();
    protected virtual void AddCondiments(){}
}
